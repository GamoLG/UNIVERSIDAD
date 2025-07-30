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
    public partial class fmAdministradores : Form
    {
        private SqlConnection _conexionBD;
        private bool _modoEdicion = false; // Controla si estamos editando o agregando
        private string _contrasenaActual = ""; // Almacena la contraseña durante edición

        public fmAdministradores(SqlConnection conexionBD)
        {
            InitializeComponent();
            _conexionBD = conexionBD;
        }

        private void fmAdministradores_Load(object sender, EventArgs e)
        {
            try
            {
                CargarAdministradores();
                ConfigurarDataGridView();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAdministradores()
        {
            cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
            DataSet ds = logicaBD.ProcedimientoAlmacenado("spu_AdministradoresSelect", "*");
            dgvAdministradores.DataSource = ds.Tables[0];
        }

        private void ConfigurarDataGridView()
        {
            dgvAdministradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdministradores.Columns["Cod_Admin"].HeaderText = "Código";
            dgvAdministradores.Columns["Nombre"].HeaderText = "Nombre";
            dgvAdministradores.Columns["Apellido"].HeaderText = "Apellido";
            dgvAdministradores.Columns["Usuario"].HeaderText = "Usuario";
        }
        private void LimpiarCampos()
        {
            // Limpia todos los TextBox dentro del GroupBox
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();

            // Restablece el modo de edición
            _modoEdicion = false;

            // Habilita el campo de código (para nuevos registros)
            txtCodigo.Enabled = true;

            // Coloca el foco en el campo Código
            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            LimpiarCampos();
            txtCodigo.Enabled = true;  // Habilita campo para nuevo código
            txtCodigo.Focus();        // Pone el foco en el campo código
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                string contrasena = _modoEdicion && string.IsNullOrEmpty(txtContrasena.Text)
                                  ? _contrasenaActual
                                  : txtContrasena.Text;

                logicaBD.ProcedimientoAlmacenado(
                    "spu_AdministradorInsertUpdate",
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtUsuario.Text,
                    contrasena
                );

                MessageBox.Show("Administrador guardado correctamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAdministradores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdministradores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un administrador", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este administrador?", "Confirmar",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string codAdmin = dgvAdministradores.CurrentRow.Cells["Cod_Admin"].Value.ToString();
                    cLogicaBD logicaBD = new cLogicaBD(_conexionBD);
                    logicaBD.ProcedimientoAlmacenado("spu_AdministradorDelete", codAdmin);

                    MessageBox.Show("Administrador eliminado", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAdministradores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvAdministradores.ClearSelection();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
