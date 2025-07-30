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
    public partial class fmPrestamos : Form
    {
        private SqlConnection _conexionBD;
        private bool _modoNuevo = true;

        public fmPrestamos(SqlConnection conexionBD)
        {
            InitializeComponent();
            _conexionBD = conexionBD;
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configuración básica del DataGridView
            dgvPrestamos.AutoGenerateColumns = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.ReadOnly = true;

            // Configurar columnas manualmente
            ConfigurarColumnasDataGridView();
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgvPrestamos.Columns.Clear();

            // Columnas según lo que devuelve spu_PrestamosActivosSelect
            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id_Prestamo",
                HeaderText = "ID",
                DataPropertyName = "Id_Prestamo",
                Width = 60
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre_Lector",
                HeaderText = "Lector",
                DataPropertyName = "Nombre_Lector",
                Width = 150
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Titulo_Libro",
                HeaderText = "Libro",
                DataPropertyName = "Titulo_Libro",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Fecha_Prestamo",
                HeaderText = "Fecha Préstamo",
                DataPropertyName = "Fecha_Prestamo",
                Width = 120
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Dias_Prestamo",
                HeaderText = "Días",
                DataPropertyName = "Dias_Prestamo",
                Width = 60
            });
        }

        private void fmPrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboboxes();
                CargarPrestamosActivos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboboxes()
        {
            // Cargar lectores activos usando spu_LectoresSelect
            DataSet dsLectores = new cLogicaBD(_conexionBD).ProcedimientoAlmacenado("spu_LectoresSelect", "*");

            // Filtrar solo activos en memoria
            DataView viewLectores = new DataView(dsLectores.Tables[0]);
            viewLectores.RowFilter = "Estado = 'Activo'";

            cmbLectores.DataSource = viewLectores;
            cmbLectores.DisplayMember = "NombreCompleto"; // Asumiendo que existe en los resultados
            cmbLectores.ValueMember = "Cod_Lector";

            // Cargar libros disponibles usando spu_LibrosSelect
            DataSet dsLibros = new cLogicaBD(_conexionBD).ProcedimientoAlmacenado("spu_LibrosSelect", "*", 1); // 1 = solo disponibles

            cmbLibros.DataSource = dsLibros.Tables[0];
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "Cod_Libro";

            // Cargar administradores usando spu_AdministradoresSelect
            DataSet dsAdmin = new cLogicaBD(_conexionBD).ProcedimientoAlmacenado("spu_AdministradoresSelect");
            cmbAdministradores.DataSource = dsAdmin.Tables[0];
            cmbAdministradores.DisplayMember = "NombreCompleto"; // Asumiendo que existe
            cmbAdministradores.ValueMember = "Cod_Admin";
        }

        private void CargarPrestamosActivos()
        {
            try
            {
                DataSet ds = new cLogicaBD(_conexionBD).ProcedimientoAlmacenado("spu_PrestamosActivosSelect");
                dgvPrestamos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cmbLectores.SelectedIndex = -1;
            cmbLibros.SelectedIndex = -1;
            cmbAdministradores.SelectedIndex = -1;
            _modoNuevo = true;
        }

        private bool ValidarCampos()
        {
            if (cmbLectores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un lector", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro disponible", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbAdministradores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un administrador", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            _modoNuevo = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                logicaBD.ProcedimientoAlmacenado(
                    "spu_PrestamoInsert",
                    cmbLectores.SelectedValue.ToString(),
                    cmbLibros.SelectedValue.ToString(),
                    cmbAdministradores.SelectedValue.ToString()
                );

                MessageBox.Show("Préstamo registrado correctamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPrestamosActivos();
                CargarComboboxes(); // Para actualizar disponibilidad de libros
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar préstamo: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPrestamosActivos();
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Implementar lógica si necesitas mostrar detalles
            }
        }
    }
}