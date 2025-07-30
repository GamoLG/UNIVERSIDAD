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
    public partial class fmAlumno : Form
    {
        SqlConnection OConexionBD;
        cLogicaBD OLogicaBD;
        /* CONSTRUCTOR */
        /* ********************************************************** */
        public fmAlumno(SqlConnection OConexionBD_)
        {
            OConexionBD = OConexionBD_;
            InitializeComponent();
            OLogicaBD = new cLogicaBD(OConexionBD_);
            Inicializar();
        }
        /* MÉTODOS */
        /* ********************************************************* */
        public void Inicializar()
        {
            tbCod_Alumno.Text = "";
            tbPaterno.Text = "";
            tbMaterno.Text = "";
            tbNombres.Text = "";
            tbCod_EP.Text = "";
            laNombre_CP.Text = "";
            tbCod_Alumno.Focus();
            // -- Desactivar botones
            buGrabar.Enabled = false;
            buEliminar.Enabled = false;
        }


        /* ********************************************************* */
        public void ProcesarConsulta()
        {
            fmConsulta OfmConsulta = new fmConsulta(OConexionBD, "Consulta de Escuelas Profesionales","spu_EscuelasSelect");
            if (OfmConsulta.ShowDialog() == DialogResult.OK)
            {
                // -- Recuperar valor de Cod_EP
                tbCod_EP.Text = OfmConsulta.FilaDatos().Cells["Cod_EP"].Value.ToString();
                laNombre_CP.Text = OfmConsulta.FilaDatos().Cells["Nombre_EP"].Value.ToString();
            }
        }        

        /* ********************************************************* */
        public void ProcesarClave()
        {
            if (tbCod_Alumno.Text != "")
            {
                // -- Activar botón grabar
                buGrabar.Enabled = true;
                // -- Intentar recuperar datos correspondientes a esta clave
                DataSet ODS = OLogicaBD.ProcedimientoAlmacenado("spu_AlumnosSelect", tbCod_Alumno.Text);
                // -- Si existe datos, mostrar
                if (ODS != null && ODS.Tables[0].Rows.Count > 0)
                {
                    DataTable Tabla = ODS.Tables[0];
                    tbPaterno.Text = Tabla.Rows[0]["Paterno"].ToString();
                    tbMaterno.Text = Tabla.Rows[0]["Materno"].ToString();
                    tbNombres.Text = Tabla.Rows[0]["Nombres"].ToString();
                    tbCod_EP.Text = Tabla.Rows[0]["Cod_EP"].ToString();
                    buEliminar.Enabled = true;
                }
            }
        }

        /* ********************************************************* */
        public void Grabar()
        {
            // -- Sólo grabar si hay por lo menos la clave primaria
            if (tbCod_Alumno.Text != "")
            {
                Exception Error = null;
                OLogicaBD.ProcedimientoAlmacenado("spu_AlumnoInsertUpdate", out Error, tbCod_Alumno.Text, tbPaterno.Text, tbMaterno.Text, tbNombres.Text, tbCod_EP.Text);
                if (Error == null)
                {
                    MessageBox.Show("Proceso realizado satisfactoriamente...");
                    Inicializar();
                }
                else
                    MessageBox.Show(Error.Message);
            }
        }

        /* ********************************************************* */
        public void Eliminar()
        {
            Exception Error = null;
            OLogicaBD.ProcedimientoAlmacenado("spu_AlumnoDelete", out Error, tbCod_Alumno.Text);
            if (Error == null)
            {
                MessageBox.Show("Proceso realizado satisfactoriamente...");
                Inicializar();
            }
            else
                MessageBox.Show(Error.Message);

        }

        /* EVENTOS */

        private void buGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcesarConsulta();
        }

        private void tbCod_Alumno_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
    }
}
