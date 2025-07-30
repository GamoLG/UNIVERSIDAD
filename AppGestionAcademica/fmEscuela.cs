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
    public partial class fmEscuela : Form
    {
        cLogicaBD OLogicaBD;
        /* CONSTRUCTOR */
        /* ********************************************************** */
        public fmEscuela(SqlConnection OConexionBD_ )
        {
            InitializeComponent();
            OLogicaBD = new cLogicaBD(OConexionBD_);
            Inicializar();
        }

        /* MÉTODOS */
        /* ********************************************************* */
        public void Inicializar()
        {
            tbCod_EP.Text = "";
            tbNombre_EP.Text = "";
            tbCod_EP.Focus();
            // -- Desactivar botones
            buGrabar.Enabled = false;
            buEliminar.Enabled = false;
        }

        /* ********************************************************* */
        public void ProcesarClave()
        {
            if (tbCod_EP.Text != "")
            {
                // -- Activar botón grabar
                buGrabar.Enabled = true;
                // -- Intentar recuperar datos correspondientes a esta clave
                DataSet ODS = OLogicaBD.ProcedimientoAlmacenado("spu_EscuelasSelect", tbCod_EP.Text);
                // -- Si existe datos, mostrar
                if (ODS != null && ODS.Tables[0].Rows.Count > 0)
                {
                    DataTable Tabla = ODS.Tables[0];
                    tbNombre_EP.Text = Tabla.Rows[0]["Nombre_EP"].ToString();
                    buEliminar.Enabled = true;
                }
            }
        }

        /* ********************************************************* */
        public void Grabar()
        {
            // -- Sólo grabar si hay por lo menos la clave primaria
            if (tbCod_EP.Text != "")
            {
                Exception Error = null;
                OLogicaBD.ProcedimientoAlmacenado("spu_EscuelaInsertUpdate", out Error, tbCod_EP.Text, tbNombre_EP.Text);
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
            OLogicaBD.ProcedimientoAlmacenado("spu_EscuelaDelete", out Error, tbCod_EP.Text);
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

        private void tbCod_EP_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void buEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
