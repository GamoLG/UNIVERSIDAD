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
    public partial class fmLectores : Form
    {
        private SqlConnection _conexionBD;
        private bool _modoEdicion = false;

        public fmLectores(SqlConnection conexionBD)
        {
            InitializeComponent();
            _conexionBD = conexionBD;
        }

        private void fmLectores_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLectores();
                ConfigurarDataGridView();
                ConfigurarComboBoxEstado();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLectores()
        {
            cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
            DataSet ds = logicaBD.ProcedimientoAlmacenado("spu_LectoresSelect", "*");
            dgvLectores.DataSource = ds.Tables[0];
        }

        private void ConfigurarDataGridView()
        {
            dgvLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLectores.Columns["Cod_Lector"].HeaderText = "Código";
            dgvLectores.Columns["Nombre"].HeaderText = "Nombre";
            dgvLectores.Columns["Apellido"].HeaderText = "Apellido";
            dgvLectores.Columns["DNI"].HeaderText = "DNI";
            dgvLectores.Columns["Estado"].HeaderText = "Estado";
        }

        private void ConfigurarComboBoxEstado()
        {
            cmbEstado.Items.AddRange(new string[] { "Activo", "Inactivo", "Suspendido" });
            cmbEstado.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txtCodLector.Clear();
            txtNombreLector.Clear();
            txtApellidoLector.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbEstado.SelectedIndex = 0;

            _modoEdicion = false;
            txtCodLector.Enabled = true;
            txtCodLector.Focus();
        }

        private void btnNuevoLector_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            LimpiarCampos();
        }

        private void btnGuardarLector_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                logicaBD.ProcedimientoAlmacenado(
                    "spu_LectorInsertUpdate",
                    txtCodLector.Text,
                    txtNombreLector.Text,
                    txtApellidoLector.Text,
                    txtDNI.Text,
                    txtTelefono.Text ?? null,  // Convierte string vacío a null
                    txtEmail.Text ?? null,     // Convierte string vacío a null
                    cmbEstado.SelectedItem.ToString()
                );

                MessageBox.Show("Lector guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLectores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarLector_Click(object sender, EventArgs e)
        {
            if (dgvLectores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un lector para cambiar estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Cambiar estado a INACTIVO?", "Confirmar",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string codLector = dgvLectores.CurrentRow.Cells["Cod_Lector"].Value.ToString();
                    cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                    logicaBD.ProcedimientoAlmacenado("spu_LectorDelete", codLector);

                    MessageBox.Show("Estado actualizado a INACTIVO.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLectores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarLector_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvLectores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLectores.Rows[e.RowIndex];
                txtCodLector.Text = row.Cells["Cod_Lector"].Value.ToString();
                txtNombreLector.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoLector.Text = row.Cells["Apellido"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"]?.Value.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"]?.Value.ToString() ?? "";
                cmbEstado.SelectedItem = row.Cells["Estado"].Value.ToString();

                _modoEdicion = true;
                txtCodLector.Enabled = false;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodLector.Text) ||
                string.IsNullOrWhiteSpace(txtNombreLector.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoLector.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Código, Nombre, Apellido y DNI son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDNI.Text.Length != 8 || !long.TryParse(txtDNI.Text, out _))
            {
                MessageBox.Show("DNI debe tener 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

      
    }
}