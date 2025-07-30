using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBibliotecaDigital
{
    public partial class fmDevoluciones : Form
    {
        private SqlConnection _conexionBD;

        public fmDevoluciones(SqlConnection conexionBD)
        {
            InitializeComponent();
            _conexionBD = conexionBD;
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar DataGridView
            dgvPrestamosActivos.AutoGenerateColumns = false;
            dgvPrestamosActivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamosActivos.AllowUserToAddRows = false;
            dgvPrestamosActivos.AllowUserToDeleteRows = false;
            dgvPrestamosActivos.ReadOnly = true;

            // Configurar columnas
            ConfigurarColumnasDataGridView();

            // Configurar ComboBox de estados
            cmbEstado.Items.AddRange(new string[] { "Devuelto", "Retrasado", "Perdido" });
            cmbEstado.SelectedIndex = 0;
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgvPrestamosActivos.Columns.Clear();

            dgvPrestamosActivos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id_Prestamo",
                HeaderText = "ID",
                DataPropertyName = "Id_Prestamo",
                Width = 60
            });

            dgvPrestamosActivos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre_Lector",
                HeaderText = "Lector",
                DataPropertyName = "Nombre_Lector",
                Width = 150
            });

            dgvPrestamosActivos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Titulo_Libro",
                HeaderText = "Libro",
                DataPropertyName = "Titulo_Libro",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestamosActivos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Fecha_Prestamo",
                HeaderText = "Fecha Préstamo",
                DataPropertyName = "Fecha_Prestamo",
                Width = 120
            });

            dgvPrestamosActivos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Dias_Prestamo",
                HeaderText = "Días",
                DataPropertyName = "Dias_Prestamo",
                Width = 60
            });
        }

        private void fmDevoluciones_Load(object sender, EventArgs e)
        {
            CargarPrestamosActivos();
            LimpiarCampos();
        }

        private void CargarPrestamosActivos()
        {
            try
            {
                DataSet ds = new cLogicaBD(_conexionBD).ProcedimientoAlmacenado("spu_PrestamosActivosSelect");
                dgvPrestamosActivos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos activos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtIdPrestamo.Clear();
            txtLector.Clear();
            txtLibro.Clear();
            txtFechaPrestamo.Clear();
            txtDiasTranscurridos.Clear();
            cmbEstado.SelectedIndex = 0;
        }

        private void dgvPrestamosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPrestamosActivos.Rows[e.RowIndex];

                txtIdPrestamo.Text = row.Cells["Id_Prestamo"].Value.ToString();
                txtLector.Text = row.Cells["Nombre_Lector"].Value.ToString();
                txtLibro.Text = row.Cells["Titulo_Libro"].Value.ToString();
                txtFechaPrestamo.Text = row.Cells["Fecha_Prestamo"].Value.ToString();
                txtDiasTranscurridos.Text = row.Cells["Dias_Prestamo"].Value.ToString();

                // Establecer estado predeterminado basado en días transcurridos
                int dias = int.Parse(txtDiasTranscurridos.Text);
                cmbEstado.SelectedItem = dias > 7 ? "Retrasado" : "Devuelto";
            }
        }

        private void btnProcesarDevolucion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPrestamo.Text))
            {
                MessageBox.Show("Seleccione un préstamo de la lista", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Primero procesamos la devolución normal
                new cLogicaBD(_conexionBD).ProcedimientoAlmacenado(
                    "spu_PrestamoDevolucion",
                    int.Parse(txtIdPrestamo.Text)
                );

                // Si el estado no es "Devuelto", actualizamos el estado
                if (cmbEstado.SelectedItem.ToString() != "Devuelto")
                {
                    new cLogicaBD(_conexionBD).ProcedimientoAlmacenado(
                        "spu_ActualizarEstadoPrestamo",
                        int.Parse(txtIdPrestamo.Text),
                        cmbEstado.SelectedItem.ToString()
                    );
                }

                MessageBox.Show("Devolución procesada correctamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPrestamosActivos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar devolución: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPrestamosActivos();
        }
    }
}
