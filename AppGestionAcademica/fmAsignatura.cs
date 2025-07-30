using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppGestionAcademica
{
    public partial class fmAsignatura : Form
    {

        cLogicaBD OLogicaBD;
        /* CONSTRUCTOR */
        /* ********************************************************** */
        public fmAsignatura(SqlConnection OConexionBD_)
        {
            InitializeComponent();
            OLogicaBD = new cLogicaBD(OConexionBD_);
            Inicializar();
        }
        /* MÉTODOS */
        /* ********************************************************* */
        public void Inicializar()
        {
            tbCod_Asignatura.Text = "";
            tbNombre_Asignatura.Text = "";
            cbCategoria.Text = "OE";
            nuCreditos.Value = 4;
            paDatos.Focus();
            tbCod_Asignatura.Focus();
            // -- Desactivar botones
            buGrabar.Enabled = false;
            buEliminar.Enabled = false;
        }

        /* ********************************************************* */
        public void ProcesarClave()
        {
            if (tbCod_Asignatura.Text != "")
            {
                // -- Activar botón grabar
                buGrabar.Enabled = true;
                // -- Intentar recuperar datos correspondientes a esta clave
                DataSet ODS = OLogicaBD.ProcedimientoAlmacenado("spu_AsignaturasSelect", tbCod_Asignatura.Text);
                // -- Si existe datos, mostrar
                if (ODS != null && ODS.Tables[0].Rows.Count > 0)
                {
                    DataTable Tabla = ODS.Tables[0];
                    tbNombre_Asignatura.Text = Tabla.Rows[0]["Nombre_Asignatura"].ToString();
                    cbCategoria.Text = Tabla.Rows[0]["Categoria"].ToString();
                    nuCreditos.Value = int.Parse(Tabla.Rows[0]["Creditos"].ToString());
                    buEliminar.Enabled = true;
                }
            }
        }

        /* ********************************************************* */
        public void Grabar()
        {
            // -- Sólo grabar si hay por lo menos la clave primaria
            if (tbCod_Asignatura.Text != "")
            {
                Exception Error = null;
                OLogicaBD.ProcedimientoAlmacenado("spu_AsignaturaInsertUpDate", out Error, tbCod_Asignatura.Text, tbNombre_Asignatura.Text, cbCategoria.Text, nuCreditos.Value);
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
            OLogicaBD.ProcedimientoAlmacenado("spu_AlumnoDelete", out Error, tbCod_Asignatura.Text);
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

        private void tbCod_Asignatura_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void buEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
