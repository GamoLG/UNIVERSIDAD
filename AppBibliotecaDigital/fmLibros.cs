using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppBibliotecaDigital
{
    public partial class fmLibros : Form
    {
        private SqlConnection _conexionBD;
        private bool _modoEdicion = false; // Para saber si estamos editando

        public fmLibros(SqlConnection conexionBD)
        {
            InitializeComponent();
            _conexionBD = conexionBD;
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
            dgvLibros.Columns.Clear();

            // Configuración de columnas según tu tabla Libro
            var columns = new[]
            {
        new { Name = "Cod_Libro", Header = "Código", Width = 80 },
        new { Name = "Titulo", Header = "Título", Width = 200 },
        new { Name = "Autor", Header = "Autor", Width = 150 },
        new { Name = "Editorial", Header = "Editorial", Width = 120 },
        new { Name = "Anio_Publicacion", Header = "Año", Width = 60 },
        new { Name = "ISBN", Header = "ISBN", Width = 100 },
        new { Name = "Categoria", Header = "Categoría", Width = 120 },
        new { Name = "Stock_Total", Header = "Total", Width = 60 },
        new { Name = "Stock_Disponible", Header = "Disponibles", Width = 80 }
    };

            foreach (var col in columns)
            {
                dgvLibros.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = col.Name,
                    HeaderText = col.Header,
                    DataPropertyName = col.Name,
                    Width = col.Width
                });
            }
        }
        private void CargarLibros(string codigoLibro = "*")
        {
            try
            {
                // Mensaje de depuración
                Debug.WriteLine($"Intentando cargar libros. Parámetros: {codigoLibro}, {chkDisponibles.Checked}");

                cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                DataSet ds = logicaBD.ProcedimientoAlmacenado(
                    "spu_LibrosSelect",
                    codigoLibro,
                    chkDisponibles.Checked ? 1 : 0  // Cambiado a int en lugar de string
                );

                // Depuración avanzada
                if (ds == null)
                {
                    MessageBox.Show("El DataSet es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("No hay tablas en el DataSet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = ds.Tables[0];

                // Mostrar información de depuración
                Debug.WriteLine($"Número de filas recibidas: {dt.Rows.Count}");
                foreach (DataColumn col in dt.Columns)
                {
                    Debug.WriteLine($"Columna: {col.ColumnName} - Tipo: {col.DataType}");
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros en la tabla", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvLibros.DataSource = dt;
                dgvLibros.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completo:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código del libro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título del libro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor del libro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 1)
            {
                MessageBox.Show("El stock debe ser un número mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtAnio.Clear();
            txtISBN.Clear();
            txtCategoria.Clear();
            txtStock.Text = "1";
            _modoEdicion = false;
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }


        private void fmLibros_Load(object sender, EventArgs e)
        {
            try
            {
                // Configurar el DataGridView
                ConfigurarDataGridView();

                // Cargar la lista de libros al iniciar
                CargarLibros();

                // Inicializar campos y deshabilitar edición hasta que se seleccione un libro
                LimpiarCampos();

                // Configuración adicional
                txtStock.Text = "1"; // Valor por defecto para stock
                //Aquiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii
                //lblMensaje.Text = "Sistema listo. Use los botones para gestionar libros.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el formulario: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                cLogicaBD logicaBD = new cLogicaBD(_conexionBD);

                // Convertir año a int? (nullable)
                int? anio = null;
                if (!string.IsNullOrWhiteSpace(txtAnio.Text) && int.TryParse(txtAnio.Text, out int anioTemp))
                {
                    anio = anioTemp;
                }

                logicaBD.ProcedimientoAlmacenado(
                    "spu_LibroInsertUpdate",
                    txtCodigo.Text,
                    txtTitulo.Text,
                    txtAutor.Text,
                    string.IsNullOrWhiteSpace(txtEditorial.Text) ? null : txtEditorial.Text,
                    anio,
                    string.IsNullOrWhiteSpace(txtISBN.Text) ? null : txtISBN.Text,
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ? null : txtCategoria.Text,
                    int.Parse(txtStock.Text)
                );

                MessageBox.Show("Libro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Seleccione un libro de la lista para editar.",
                              "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Activar modo edición
                _modoEdicion = true;
                txtCodigo.Enabled = false; // Bloquear código (no se puede modificar la PK)

                // Habilitar/deshabilitar controles según necesidad
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;

                // Enfocar el primer campo editable
                txtTitulo.Focus();
                //aquiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii
                // lblMensaje.Text = $"Editando libro: {txtCodigo.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al preparar la edición: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Seleccione un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                    logicaBD.ProcedimientoAlmacenado("spu_LibroDelete", txtCodigo.Text);
                    MessageBox.Show("Libro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLibros();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBusqueda = string.IsNullOrWhiteSpace(txtCodigo.Text) ? "*" : txtCodigo.Text;
            CargarLibros(codigoBusqueda);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarLibros();
        }

        private void chkDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Solo procesar si se hizo clic en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvLibros.Rows[e.RowIndex];

                    // Cargar todos los datos del libro seleccionado
                    txtCodigo.Text = row.Cells["Cod_Libro"].Value?.ToString() ?? "";
                    txtTitulo.Text = row.Cells["Titulo"].Value?.ToString() ?? "";
                    txtAutor.Text = row.Cells["Autor"].Value?.ToString() ?? "";
                    txtEditorial.Text = row.Cells["Editorial"].Value?.ToString() ?? "";
                    txtAnio.Text = row.Cells["Anio_Publicacion"].Value?.ToString() ?? "";
                    txtISBN.Text = row.Cells["ISBN"].Value?.ToString() ?? "";
                    txtCategoria.Text = row.Cells["Categoria"].Value?.ToString() ?? "";
                    txtStock.Text = row.Cells["Stock_Total"].Value?.ToString() ?? "1";

                    // Activar modo edición
                    _modoEdicion = true;
                    txtCodigo.Enabled = false;

                    // Opcional: Resaltar fila seleccionada
                    row.Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Método auxiliar para manejar valores nulos
        private string SafeCellValue(DataGridViewRow row, string columnName, string defaultValue = "")
        {
            if (row.Cells[columnName].Value == null)
                return defaultValue;

            return row.Cells[columnName].Value.ToString();
        }

     
    }
}