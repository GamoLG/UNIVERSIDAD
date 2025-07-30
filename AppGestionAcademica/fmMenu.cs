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

namespace AppGestionAcademica
{
    public partial class fmMenu : Form
    {
        SqlConnection OConexionBD;
        public fmMenu()
        {
            InitializeComponent();
            // -- Inicializar base de datos
            string NombreServidor = "DESKTOP-D7UFLKT";
            string NombreBaseDatos = "BD_Gestion_Academica";
            string ConexionBD = "Data Source = "+NombreServidor+"; Initial Catalog = "+NombreBaseDatos+"; Integrated Security = True";
            OConexionBD = new SqlConnection(ConexionBD);            
        }

        private void miEscuelasProfesionales_Click(object sender, EventArgs e)
        {
            fmEscuela OfmEscuela = new fmEscuela(OConexionBD);
            OfmEscuela.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAlumno OfmAlumno = new fmAlumno(OConexionBD);
            OfmAlumno.ShowDialog();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAsignatura OfmAsignatura = new fmAsignatura(OConexionBD);
            OfmAsignatura.ShowDialog();
        }

        private void escuelasProfesionalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmReporteEscuelas OfmReporteEscuelas = new fmReporteEscuelas(OConexionBD);
            OfmReporteEscuelas.ShowDialog();
        }

        private void matrículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmMatricula OfmMatricula = new fmMatricula(OConexionBD);
            OfmMatricula.ShowDialog();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmReporteAlumnos OfmReporteAlumnos = new fmReporteAlumnos(OConexionBD);
            OfmReporteAlumnos.ShowDialog();
        }

        private void asignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmReporteAsignaturas OfmReporteAsignaturas = new fmReporteAsignaturas(OConexionBD);
            OfmReporteAsignaturas.ShowDialog();
        }
    }
}
