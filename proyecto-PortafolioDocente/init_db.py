import sqlite3
from werkzeug.security import generate_password_hash

def init_db():
    conn = sqlite3.connect('database.db')
    cursor = conn.cursor()
    
    # Tabla de administradores
    cursor.execute('''
    CREATE TABLE IF NOT EXISTS administradores (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        email TEXT UNIQUE NOT NULL,
        password TEXT NOT NULL
    )
    ''')
    
    # Tabla de docentes
    cursor.execute('''
    CREATE TABLE IF NOT EXISTS docentes (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nombre TEXT NOT NULL,
        email TEXT UNIQUE NOT NULL,
        password TEXT NOT NULL
    )
    ''')
    
    # Tabla de archivos docentes (archivos que SUBEN los docentes)
    cursor.execute('''
    CREATE TABLE IF NOT EXISTS archivos_docentes (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        docente_id INTEGER NOT NULL,
        tipo TEXT NOT NULL CHECK (tipo IN ('caratula', 'carga_lectiva', 'cv', 'filosofia')),
        ruta_archivo TEXT NOT NULL,
        fecha_subida DATETIME DEFAULT CURRENT_TIMESTAMP,
        FOREIGN KEY (docente_id) REFERENCES docentes(id)
    )
    ''')
    
    # Tabla de formatos (plantillas que SUBE el admin para que descarguen los docentes)
    cursor.execute('''
    CREATE TABLE IF NOT EXISTS formatos (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        tipo TEXT UNIQUE NOT NULL CHECK (tipo IN ('caratula', 'carga_lectiva', 'cv', 'filosofia')),
        ruta_archivo TEXT NOT NULL,
        fecha_subida DATETIME DEFAULT CURRENT_TIMESTAMP
    )
    ''')
    
    # Tabla de cursos
    cursor.execute('''
    CREATE TABLE IF NOT EXISTS cursos (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nombre TEXT NOT NULL
    )
    ''')
    
    # Tabla de relación docente-curso
    cursor.execute('''
    CREATE TABLE IF NOT EXISTS docente_curso (
        docente_id INTEGER NOT NULL,
        curso_id INTEGER NOT NULL,
        PRIMARY KEY (docente_id, curso_id),
        FOREIGN KEY (docente_id) REFERENCES docentes(id),
        FOREIGN KEY (curso_id) REFERENCES cursos(id)
    )
    ''')
    
    # Insertar admin por defecto
    cursor.execute("INSERT OR IGNORE INTO administradores (email, password) VALUES (?, ?)",
                  ('admin@unsaac.edu.pe', generate_password_hash('admin123')))
    
    # Insertar docente de ejemplo
    cursor.execute("INSERT OR IGNORE INTO docentes (nombre, email, password) VALUES (?, ?, ?)",
                  ('Jhoel Mamani', 'jhoel@unsaac.edu.pe', generate_password_hash('jhoel123')))
    
    # Insertar cursos de ejemplo
    cursor.execute("INSERT OR IGNORE INTO cursos (nombre) VALUES ('Algoritmos Paralelos')")
    cursor.execute("INSERT OR IGNORE INTO cursos (nombre) VALUES ('Base de Datos')")
    
    # Asignar cursos al docente
    cursor.execute("INSERT OR IGNORE INTO docente_curso (docente_id, curso_id) VALUES (1, 1)")
    cursor.execute("INSERT OR IGNORE INTO docente_curso (docente_id, curso_id) VALUES (1, 2)")
    
    conn.commit()
    conn.close()
    print("Base de datos inicializada correctamente")
    print("Tablas creadas:")
    print("- administradores")
    print("- docentes") 
    print("- archivos_docentes (para archivos que suben los docentes)")
    print("- formatos (para plantillas que sube el admin)")
    print("- cursos")
    print("- docente_curso")

if __name__ == '__main__':
    init_db()