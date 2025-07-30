using AppBibliotecaDigital;
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
    public partial class fmMenu : Form
    {
        SqlConnection OConexionBD;
        public fmMenu()
        {
            InitializeComponent();
            // -- Inicializar base de datos
            string NombreServidor = "DESKTOP-AL9HIIO\\SQLEXPRESS";
            string NombreBaseDatos = "BD_Biblioteca_Digital";
            string ConexionBD = "Data Source = " + NombreServidor + "; Initial Catalog = " + NombreBaseDatos + "; Integrated Security = True";
            OConexionBD = new SqlConnection(ConexionBD);
        }
        //ENTORNO PARA LA PRESENTACION


        //ES HASTA AQUI LA PRESENTACION
        private void fmMenu_Load(object sender, EventArgs e)
        {
            // Mostrar fecha y hora al cargar
            sslFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            sslHora.Text = "Hora: " + DateTime.Now.ToShortTimeString();

            // Configurar el timer para actualizar la hora cada segundo
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += (s, ev) => {
                sslHora.Text = "Hora: " + DateTime.Now.ToShortTimeString();
            };
            timer.Start();

            // Verificar conexión a BD (parte opcional)
            try
            {
                if (OConexionBD.State == ConnectionState.Closed)
                    OConexionBD.Open();

                sslEstadoBD.Text = "BD: Conectado";
                sslEstadoBD.BackColor = Color.LightGreen;
                OConexionBD.Close();
            }
            catch (Exception ex)
            {
                sslEstadoBD.Text = "BD: Error";
                sslEstadoBD.BackColor = Color.LightCoral;
                // Opcional: mostrar mensaje de error
                // MessageBox.Show("Error conectando a la BD: " + ex.Message);
            }

            // Mostrar usuario (deberás setearlo después del login)
            sslUsuario.Text = "Usuario: [Invitado]";
        }

        private void tsmiAdministradores_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el formulario ya está abierto
                foreach (Form form in Application.OpenForms)
                {
                    if (form is fmAdministradores && !form.IsDisposed)
                    {
                        form.BringToFront(); // Lo trae al frente si ya está abierto
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal; // Restaura si estaba minimizado
                        }
                        return;
                    }
                }

                // Si no está abierto, crea una nueva instancia como ventana independiente
                fmAdministradores formAdmin = new fmAdministradores(OConexionBD);
                formAdmin.Show(); // Abre como ventana independiente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir administradores: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiLectores_Click(object sender, EventArgs e)
        {
            try
            {
                fmLectores formLectores = new fmLectores(OConexionBD);
                formLectores.Show(); // Para ventana independiente
                                     // o: formLectores.ShowDialog(); // Para ventana modal
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir lectores: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiLibros_Click(object sender, EventArgs e)
        {
            try
            {
                fmLibros formLibros = new fmLibros(OConexionBD);
                formLibros.Show(); // Para ventana independiente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiPrestamos_Click(object sender, EventArgs e)
        {
            try
            {
                fmPrestamos formPrestamos = new fmPrestamos(OConexionBD);
                formPrestamos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir préstamos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickAquiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fmClickAqui formClickAqui = new fmClickAqui();
                formClickAqui.Show(); // Para ventana independiente
                                     // o: formLectores.ShowDialog(); // Para ventana modal
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir lectores: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsmiDevoluciones_Click(object sender, EventArgs e)
        {
            fmDevoluciones formDevoluciones = new fmDevoluciones(OConexionBD);
            formDevoluciones.ShowDialog();
        }
        private void tsmiPrestamosActivos_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea y muestra una nueva instancia del formulario
                fmPrestamosActivos prestamosActivos = new fmPrestamosActivos(OConexionBD);
                prestamosActivos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir préstamos activos: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiHistorialPrestamos_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si ya está abierto
                foreach (Form form in Application.OpenForms)
                {
                    if (form is fmHistorialPrestamos)
                    {
                        form.BringToFront();
                        return;
                    }
                }

                // Si no, crear nuevo
                fmHistorialPrestamos formHistorial = new fmHistorialPrestamos(OConexionBD);
                formHistorial.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir historial: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            using (fmSalir formSalir = new fmSalir())
            {
                if (formSalir.ShowDialog() == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
