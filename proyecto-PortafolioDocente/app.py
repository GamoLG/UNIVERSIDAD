from flask import Flask, render_template, request, redirect, url_for, session, flash
from werkzeug.security import generate_password_hash, check_password_hash
from werkzeug.utils import secure_filename
import sqlite3
import os
from reportlab.pdfgen import canvas
from io import BytesIO
import pandas as pd
from flask import send_file
from flask import send_from_directory


app = Flask(__name__)
app.secret_key = 'tu_clave_secreta_aqui'
app.config['UPLOAD_FOLDER'] = 'static/uploads'

# Conexión a la base de datos
def get_db_connection():
    conn = sqlite3.connect('database.db')
    conn.row_factory = sqlite3.Row
    return conn

# Función para asegurar que el directorio de uploads existe
def ensure_upload_directory():
    """Asegurar que el directorio de uploads existe"""
    upload_dir = app.config['UPLOAD_FOLDER']
    if not os.path.exists(upload_dir):
        os.makedirs(upload_dir)
        print(f"Directorio de uploads creado: {upload_dir}")
    else:
        print(f"Directorio de uploads existe: {upload_dir}")

# Ruta principal
@app.route('/')
def index():
    return render_template('index.html')

# Login
@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']
        user_type = request.form['user_type']
        
        conn = get_db_connection()
        
        if user_type == 'admin':
            admin = conn.execute('SELECT * FROM administradores WHERE email = ?', (email,)).fetchone()
            if admin and check_password_hash(admin['password'], password):
                session['user_id'] = admin['id']
                session['user_type'] = 'admin'
                conn.close()
                return redirect(url_for('admin_dashboard'))
        else:
            docente = conn.execute('SELECT * FROM docentes WHERE email = ?', (email,)).fetchone()
            if docente and check_password_hash(docente['password'], password):
                session['user_id'] = docente['id']
                session['user_type'] = 'docente'
                conn.close()
                return redirect(url_for('perfil_docente', docente_id=docente['id']))
        
        conn.close()
        flash('Credenciales incorrectas', 'error')
        return redirect(url_for('login'))
    
    return render_template('login.html')

# CORREGIDO: Descargar formato desde la tabla formatos
@app.route('/descargar_formato/<tipo>')
def descargar_formato(tipo):
    """Permite descargar formatos/plantillas para los diferentes tipos de archivos"""
    
    # Verificar que el usuario esté logueado como docente
    if 'user_type' not in session or session['user_type'] != 'docente':
        return redirect(url_for('login'))
    
    # Validar que el tipo sea válido
    tipos_validos = ['caratula', 'carga_lectiva', 'cv', 'filosofia']
    if tipo not in tipos_validos:
        flash('Tipo de formato no válido', 'error')
        return redirect(url_for('perfil_docente', docente_id=session['user_id']))
    
    conn = get_db_connection()
    formato = conn.execute('SELECT * FROM formatos WHERE tipo = ?', (tipo,)).fetchone()
    conn.close()
    
    if formato:
        try:
            formatos_folder = os.path.join('static', 'formatos')
            filepath = os.path.join(formatos_folder, formato['ruta_archivo'])
            
            if os.path.exists(filepath):
                return send_file(filepath, as_attachment=True, 
                               download_name=f'formato_{tipo}.pdf')
            else:
                flash('Archivo de formato no encontrado', 'error')
        except Exception as e:
            flash(f'Error al descargar formato: {str(e)}', 'error')
    else:
        nombres_tipos = {
            'caratula': 'Carátula',
            'carga_lectiva': 'Carga Lectiva', 
            'cv': 'Curriculum Vitae',
            'filosofia': 'Filosofía'
        }
        flash(f'Formato de {nombres_tipos[tipo]} no disponible', 'info')
    
    return redirect(url_for('perfil_docente', docente_id=session['user_id']))

# CORREGIDO: Subir formato (admin)
@app.route('/admin/subir_formato', methods=['GET', 'POST'])
def subir_formato():
    """Permite al administrador subir formatos PDF para que los docentes los descarguen"""
    
    # Verificar que sea administrador
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    if request.method == 'POST':
        tipo_formato = request.form['tipo_formato']
        
        # Verificar que se seleccionó un archivo
        if 'archivo' not in request.files:
            flash('No se seleccionó ningún archivo', 'error')
            return redirect(url_for('subir_formato'))
        
        archivo = request.files['archivo']
        
        if archivo.filename == '':
            flash('No se seleccionó ningún archivo', 'error')
            return redirect(url_for('subir_formato'))
        
        # Verificar que sea PDF
        if archivo and allowed_file(archivo.filename):
            # Crear carpeta de formatos si no existe
            formatos_folder = os.path.join('static', 'formatos')
            if not os.path.exists(formatos_folder):
                os.makedirs(formatos_folder)
            
            # Nombre del archivo basado en el tipo
            filename = f'formato_{tipo_formato}.pdf'
            filepath = os.path.join(formatos_folder, filename)
            
            try:
                # Guardar el archivo
                archivo.save(filepath)
                
                # Guardar en base de datos (tabla para formatos)
                conn = get_db_connection()
                
                # Crear tabla de formatos si no existe
                conn.execute('''
                    CREATE TABLE IF NOT EXISTS formatos (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        tipo TEXT UNIQUE NOT NULL,
                        ruta_archivo TEXT NOT NULL,
                        fecha_subida DATETIME DEFAULT CURRENT_TIMESTAMP
                    )
                ''')
                
                # Insertar o actualizar el formato
                conn.execute('''
                    INSERT OR REPLACE INTO formatos (tipo, ruta_archivo) 
                    VALUES (?, ?)
                ''', (tipo_formato, filename))
                
                conn.commit()
                conn.close()
                
                flash(f'Formato de {tipo_formato} subido correctamente', 'success')
                
            except Exception as e:
                flash(f'Error al subir el archivo: {str(e)}', 'error')
        else:
            flash('Solo se permiten archivos PDF', 'error')
        
        return redirect(url_for('subir_formato'))
    
    # GET request - mostrar formulario con formatos existentes
    conn = get_db_connection()
    formatos_existentes = conn.execute('SELECT * FROM formatos ORDER BY tipo').fetchall()
    conn.close()
    
    return render_template('admin/subir_formato.html', formatos=formatos_existentes)

# CORREGIDO: Una sola función para gestionar cursos
@app.route('/admin/gestionar_cursos')
def gestionar_cursos():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    conn = get_db_connection()
    cursos = conn.execute('SELECT * FROM cursos ORDER BY nombre').fetchall()
    conn.close()
    
    return render_template('admin/gestionar_cursos.html', cursos=cursos)

@app.route('/admin/gestionar_formatos')
def gestionar_formatos():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    # Obtener formatos existentes de la base de datos
    conn = get_db_connection()
    formatos_db = conn.execute('SELECT * FROM formatos ORDER BY tipo').fetchall()
    conn.close()
    
    # Tipos de formatos permitidos
    tipos_permitidos = ['caratula', 'carga_lectiva', 'cv', 'filosofia']
    
    return render_template('admin/gestionar_formatos.html', 
                         formatos=formatos_db, 
                         tipos_permitidos=tipos_permitidos)

# CORREGIDO: Perfil docente con debug mejorado y archivos_dict
@app.route('/docente/<int:docente_id>')
def perfil_docente(docente_id):
    if 'user_type' not in session or session['user_type'] != 'docente' or session['user_id'] != docente_id:
        return redirect(url_for('login'))
    
    conn = get_db_connection()
    docente = conn.execute('SELECT * FROM docentes WHERE id = ?', (docente_id,)).fetchone()
    
    # CORREGIDO: Consulta de archivos con mejor debug
    archivos = conn.execute('''
        SELECT id, docente_id, tipo, ruta_archivo, fecha_subida 
        FROM archivos_docentes 
        WHERE docente_id = ?
        ORDER BY fecha_subida DESC
    ''', (docente_id,)).fetchall()
    
    # Debug mejorado
    print(f"=== DEBUG PERFIL DOCENTE ===")
    print(f"Docente ID: {docente_id}")
    print(f"Session user_id: {session.get('user_id')}")
    print(f"Docente encontrado: {docente['nombre'] if docente else 'No encontrado'}")
    print(f"Archivos encontrados: {len(archivos)}")
    
    # Convertir archivos a diccionarios para mejor manejo
    archivos_dict = {}
    for archivo in archivos:
        tipo = archivo['tipo']
        print(f"- Archivo: ID={archivo['id']}, Tipo={tipo}, Ruta={archivo['ruta_archivo']}")
        
        # Verificar si el archivo físico existe
        file_path = os.path.join(app.config['UPLOAD_FOLDER'], archivo['ruta_archivo'])
        exists = os.path.exists(file_path)
        print(f"  -> Archivo existe físicamente: {exists}")
        print(f"  -> Ruta completa: {file_path}")
        
        # Agregar al diccionario por tipo
        archivos_dict[tipo] = {
            'id': archivo['id'],
            'ruta_archivo': archivo['ruta_archivo'],
            'fecha_subida': archivo['fecha_subida'],
            'existe_fisicamente': exists
        }
    
    print(f"Archivos por tipo: {list(archivos_dict.keys())}")
    
    # Verificar formatos disponibles para descargar
    formatos_disponibles = conn.execute('SELECT tipo FROM formatos').fetchall()
    formatos_list = [f['tipo'] for f in formatos_disponibles]
    print(f"Formatos disponibles para descargar: {formatos_list}")
    
    cursos = conn.execute('''
        SELECT c.id, c.nombre 
        FROM cursos c
        JOIN docente_curso dc ON c.id = dc.curso_id
        WHERE dc.docente_id = ?
    ''', (docente_id,)).fetchall()
    
    conn.close()
    
    return render_template('perfil.html', 
                         docente=docente, 
                         archivos=archivos,
                         archivos_dict=archivos_dict,  # Nuevo: diccionario para fácil acceso
                         cursos=cursos,
                         formatos_disponibles=formatos_list)

# NUEVO: Ruta de debug para verificar archivos
@app.route('/debug/archivos/<int:docente_id>')
def debug_archivos(docente_id):
    """Ruta de debug para verificar archivos en la base de datos"""
    if 'user_type' not in session or session['user_type'] != 'docente':
        return "Acceso denegado"
    
    conn = get_db_connection()
    archivos = conn.execute('''
        SELECT * FROM archivos_docentes 
        WHERE docente_id = ?
    ''', (docente_id,)).fetchall()
    conn.close()
    
    result = f"<h2>Debug - Archivos para docente {docente_id}</h2>"
    result += f"<p>Total archivos encontrados: {len(archivos)}</p>"
    
    for archivo in archivos:
        file_path = os.path.join(app.config['UPLOAD_FOLDER'], archivo['ruta_archivo'])
        exists = os.path.exists(file_path)
        
        result += f"""
        <div style='border: 1px solid #ccc; margin: 10px; padding: 10px;'>
            <strong>ID:</strong> {archivo['id']}<br>
            <strong>Tipo:</strong> {archivo['tipo']}<br>
            <strong>Ruta:</strong> {archivo['ruta_archivo']}<br>
            <strong>Fecha:</strong> {archivo['fecha_subida']}<br>
            <strong>Ruta completa:</strong> {file_path}<br>
            <strong>Archivo existe:</strong> {'✅ SÍ' if exists else '❌ NO'}<br>
        </div>
        """
    
    return result

# CORREGIDO: Subir archivos con mejor debug y validaciones
@app.route('/subir_archivo/<int:docente_id>', methods=['POST'])
def subir_archivo(docente_id):
    if 'user_type' not in session or session['user_type'] != 'docente' or session['user_id'] != docente_id:
        return redirect(url_for('login'))
    
    print(f"=== SUBIENDO ARCHIVO ===")
    print(f"Docente ID: {docente_id}")
    print(f"Files en request: {list(request.files.keys())}")
    print(f"Form data: {dict(request.form)}")
    
    if 'archivo' not in request.files:
        flash('No se seleccionó ningún archivo', 'error')
        return redirect(url_for('perfil_docente', docente_id=docente_id))
    
    archivo = request.files['archivo']
    tipo_archivo = request.form['tipo_archivo']
    
    print(f"Archivo seleccionado: {archivo.filename}")
    print(f"Tipo de archivo: {tipo_archivo}")
    
    if archivo.filename == '':
        flash('No se seleccionó ningún archivo', 'error')
        return redirect(url_for('perfil_docente', docente_id=docente_id))
    
    # Validar tipo de archivo
    tipos_validos = ['caratula', 'carga_lectiva', 'cv', 'filosofia']
    if tipo_archivo not in tipos_validos:
        flash('Tipo de archivo no válido', 'error')
        return redirect(url_for('perfil_docente', docente_id=docente_id))
    
    if archivo and allowed_file(archivo.filename):
        # Asegurar que el directorio existe
        ensure_upload_directory()
        
        filename = secure_filename(f"{docente_id}_{tipo_archivo}_{archivo.filename}")
        filepath = os.path.join(app.config['UPLOAD_FOLDER'], filename)
        
        print(f"Nombre de archivo seguro: {filename}")
        print(f"Ruta completa: {filepath}")
        
        try:
            # Guardar el archivo físico
            archivo.save(filepath)
            print(f"✅ Archivo guardado físicamente en: {filepath}")
            
            # Verificar que se guardó correctamente
            if os.path.exists(filepath):
                print(f"✅ Verificación: archivo existe en el sistema de archivos")
                file_size = os.path.getsize(filepath)
                print(f"Tamaño del archivo: {file_size} bytes")
            else:
                print(f"❌ ERROR: archivo NO existe después de guardarlo")
                raise Exception("El archivo no se guardó correctamente")
            
            conn = get_db_connection()
            
            # Eliminar archivo anterior del mismo tipo
            deleted = conn.execute('DELETE FROM archivos_docentes WHERE docente_id = ? AND tipo = ?', 
                         (docente_id, tipo_archivo))
            print(f"Archivos anteriores eliminados: {deleted.rowcount}")
            
            # Insertar nuevo archivo en la base de datos
            conn.execute('''
                INSERT INTO archivos_docentes (docente_id, tipo, ruta_archivo) 
                VALUES (?, ?, ?)
            ''', (docente_id, tipo_archivo, filename))
            
            conn.commit()
            
            # Verificar que se insertó en la base de datos
            verificacion = conn.execute('''
                SELECT * FROM archivos_docentes 
                WHERE docente_id = ? AND tipo = ? AND ruta_archivo = ?
            ''', (docente_id, tipo_archivo, filename)).fetchone()
            
            if verificacion:
                print(f"✅ Verificación BD: registro insertado correctamente")
                print(f"   ID: {verificacion['id']}")
                print(f"   Docente: {verificacion['docente_id']}")
                print(f"   Tipo: {verificacion['tipo']}")
                print(f"   Archivo: {verificacion['ruta_archivo']}")
            else:
                print(f"❌ ERROR: registro NO encontrado en la base de datos")
            
            conn.close()
            
            flash('Archivo subido correctamente', 'success')
            
        except Exception as e:
            print(f"❌ ERROR al subir archivo: {str(e)}")
            flash(f'Error al subir archivo: {str(e)}', 'error')
            
            # Limpiar archivo si hubo error en BD
            if os.path.exists(filepath):
                os.remove(filepath)
    else:
        flash('Solo se permiten archivos PDF', 'error')
    
    return redirect(url_for('perfil_docente', docente_id=docente_id))

def allowed_file(filename):
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in ['pdf']

# Página de curso
@app.route('/curso/<int:docente_id>/<int:curso_id>')
def curso(docente_id, curso_id):
    if 'user_type' not in session or session['user_type'] != 'docente' or session['user_id'] != docente_id:
        return redirect(url_for('login'))
    
    conn = get_db_connection()
    curso = conn.execute('SELECT * FROM cursos WHERE id = ?', (curso_id,)).fetchone()
    conn.close()
    
    return render_template('curso.html', curso=curso)

# Panel del administrador
@app.route('/admin/dashboard')
def admin_dashboard():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    conn = get_db_connection()
    total_docentes = conn.execute('SELECT COUNT(*) FROM docentes').fetchone()[0]
    total_cursos = conn.execute('SELECT COUNT(*) FROM cursos').fetchone()[0]
    conn.close()
    
    return render_template('admin/dashboard.html', 
                         total_docentes=total_docentes, 
                         total_cursos=total_cursos)

# Gestión de docentes (admin)
@app.route('/admin/docentes')
def gestion_docentes():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    conn = get_db_connection()
    docentes = conn.execute('SELECT * FROM docentes').fetchall()
    conn.close()
    
    return render_template('admin/gestion_docentes.html', docentes=docentes)

# Agregar docente (admin)
@app.route('/admin/agregar_docente', methods=['GET', 'POST'])
def agregar_docente():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    if request.method == 'POST':
        nombre = request.form['nombre']
        email = request.form['email']
        password = generate_password_hash(request.form['password'])
        
        conn = get_db_connection()
        try:
            conn.execute('INSERT INTO docentes (nombre, email, password) VALUES (?, ?, ?)',
                        (nombre, email, password))
            conn.commit()
            flash('Docente agregado correctamente', 'success')
        except sqlite3.IntegrityError:
            flash('El correo ya está registrado', 'error')
        finally:
            conn.close()
        
        return redirect(url_for('gestion_docentes'))
    
    return render_template('admin/agregar_docente.html')

# Asignar cursos
@app.route('/admin/asignar_cursos', methods=['GET', 'POST'])
def asignar_cursos():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))
    
    conn = get_db_connection()
    
    if request.method == 'POST':
        docente_id = request.form['docente_id']
        curso_id = request.form['curso_id']
        
        try:
            conn.execute('INSERT OR IGNORE INTO docente_curso (docente_id, curso_id) VALUES (?, ?)', 
                         (docente_id, curso_id))
            conn.commit()
            flash('Curso asignado correctamente', 'success')
        except sqlite3.IntegrityError:
            flash('Esta asignación ya existe', 'error')
        
        return redirect(url_for('asignar_cursos'))
    
    # Obtener docentes y cursos para el formulario
    docentes = conn.execute('SELECT id, nombre FROM docentes').fetchall()
    cursos = conn.execute('SELECT id, nombre FROM cursos').fetchall()
    conn.close()
    
    return render_template('admin/asignar_cursos.html', docentes=docentes, cursos=cursos)

# Generar reportes
@app.route('/admin/generar_reportes', methods=['GET', 'POST'])
def generar_reportes():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))

    if request.method == 'POST':
        report_type = request.form.get('report_type')
        conn = get_db_connection()
        
        try:
            if report_type == 'docentes':
                data = conn.execute('SELECT id, nombre, email FROM docentes').fetchall()
                filename = 'reporte_docentes'
                columns = ['ID', 'Nombre', 'Email']
                
            elif report_type == 'cursos':
                data = conn.execute('''
                    SELECT c.nombre AS curso, d.nombre AS docente 
                    FROM cursos c
                    JOIN docente_curso dc ON c.id = dc.curso_id
                    JOIN docentes d ON d.id = dc.docente_id
                ''').fetchall()
                filename = 'reporte_cursos'
                columns = ['Curso', 'Docente']
                
            elif report_type == 'archivos':
                data = conn.execute('''
                    SELECT d.nombre AS docente, a.tipo, a.ruta_archivo
                    FROM archivos_docentes a
                    JOIN docentes d ON d.id = a.docente_id
                ''').fetchall()
                filename = 'reporte_archivos'
                columns = ['Docente', 'Tipo', 'Archivo']
            
            # Convertir a lista de diccionarios
            data = [dict(row) for row in data]
            
            if request.form.get('format') == 'pdf':
                from reportlab.lib.pagesizes import letter
                from reportlab.platypus import SimpleDocTemplate, Table, TableStyle
                
                buffer = BytesIO()
                pdf = SimpleDocTemplate(buffer, pagesize=letter)
                
                # Preparar datos para la tabla
                table_data = [columns] + [[str(item[col]) for col in item.keys()] for item in data]
                
                # Crear tabla
                table = Table(table_data)
                table.setStyle(TableStyle([
                    ('BACKGROUND', (0, 0), (-1, 0), '#800000'),
                    ('TEXTCOLOR', (0, 0), (-1, 0), (1, 1, 1)),
                    ('ALIGN', (0, 0), (-1, -1), 'CENTER'),
                    ('FONTNAME', (0, 0), (-1, 0), 'Helvetica-Bold'),
                    ('FONTSIZE', (0, 0), (-1, 0), 12),
                    ('BOTTOMPADDING', (0, 0), (-1, 0), 12),
                    ('BACKGROUND', (0, 1), (-1, -1), '#f5f5f5'),
                    ('GRID', (0, 0), (-1, -1), 1, '#cccccc')
                ]))
                
                pdf.build([table])
                buffer.seek(0)
                return send_file(
                    buffer,
                    as_attachment=True,
                    download_name=f'{filename}.pdf',
                    mimetype='application/pdf'
                )
                
            else:  # Excel
                import pandas as pd
                
                output = BytesIO()
                df = pd.DataFrame(data)
                df.to_excel(output, index=False, engine='openpyxl')
                output.seek(0)
                
                return send_file(
                    output,
                    as_attachment=True,
                    download_name=f'{filename}.xlsx',
                    mimetype='application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'
                )
                
        finally:
            conn.close()

    return render_template('admin/generar_reportes.html')

# Crear curso
@app.route('/admin/crear_curso', methods=['GET', 'POST'])
def crear_curso():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))

    if request.method == 'POST':
        nombre_curso = request.form['nombre']
        
        conn = get_db_connection()
        try:
            conn.execute('INSERT INTO cursos (nombre) VALUES (?)', (nombre_curso,))
            conn.commit()
            flash('Curso creado exitosamente', 'success')
        except sqlite3.IntegrityError:
            flash('Este curso ya existe', 'error')
        finally:
            conn.close()
        
        return redirect(url_for('crear_curso'))

    return render_template('admin/crear_curso.html')

# Listar cursos
@app.route('/admin/cursos')
def listar_cursos():
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))

    conn = get_db_connection()
    cursos = conn.execute('SELECT * FROM cursos ORDER BY nombre').fetchall()
    conn.close()
    
    return render_template('admin/listar_cursos.html', cursos=cursos)

# Eliminar curso
@app.route('/admin/eliminar_curso/<int:curso_id>', methods=['POST'])
def eliminar_curso(curso_id):
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))

    conn = get_db_connection()
    try:
        # Verificar si el curso está asignado a docentes primero
        asignaciones = conn.execute('SELECT COUNT(*) FROM docente_curso WHERE curso_id = ?', (curso_id,)).fetchone()[0]
        
        if asignaciones > 0:
            flash('No se puede eliminar: el curso está asignado a docentes', 'error')
        else:
            conn.execute('DELETE FROM cursos WHERE id = ?', (curso_id,))
            conn.commit()
            flash('Curso eliminado correctamente', 'success')
    finally:
        conn.close()
    
    return redirect(url_for('listar_cursos'))

# Editar curso
@app.route('/admin/editar_curso/<int:curso_id>', methods=['GET', 'POST'])
def editar_curso(curso_id):
    if 'user_type' not in session or session['user_type'] != 'admin':
        return redirect(url_for('login'))

    conn = get_db_connection()
    
    if request.method == 'POST':
        nuevo_nombre = request.form['nombre']
        try:
            conn.execute('UPDATE cursos SET nombre = ? WHERE id = ?', (nuevo_nombre, curso_id))
            conn.commit()
            flash('Curso actualizado correctamente', 'success')
            return redirect(url_for('listar_cursos'))
        except sqlite3.IntegrityError:
            flash('Ya existe un curso con ese nombre', 'error')
    
    curso = conn.execute('SELECT * FROM cursos WHERE id = ?', (curso_id,)).fetchone()
    conn.close()
    
    if not curso:
        flash('Curso no encontrado', 'error')
        return redirect(url_for('listar_cursos'))
    
    return render_template('admin/editar_curso.html', curso=curso)

# Logout
@app.route('/logout')
def logout():
    session.clear()
    return redirect(url_for('index'))

# Inicialización mejorada de la aplicación
if __name__ == '__main__':
    # Verificar/crear base de datos
    if not os.path.exists('database.db'):
        from init_db import init_db
        init_db()
    
    # Crear directorio de uploads
    ensure_upload_directory()
    
    print(f"=== CONFIGURACIÓN DE LA APP ===")
    print(f"Upload folder: {app.config['UPLOAD_FOLDER']}")
    print(f"Upload folder existe: {os.path.exists(app.config['UPLOAD_FOLDER'])}")
    print(f"Base de datos existe: {os.path.exists('database.db')}")
    
    app.run(debug=True)