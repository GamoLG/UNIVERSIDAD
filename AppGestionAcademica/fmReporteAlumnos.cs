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
    public partial class fmReporteAlumnos : Form
    {
        cLogicaBD OLogicaBD;
        /* CONSTRUCTOR */
        /* ********************************************************** */
        public fmReporteAlumnos(SqlConnection OConexionBD_)
        {
            InitializeComponent();
            OLogicaBD = new cLogicaBD(OConexionBD_);
            Inicializar();
        }
        /* MÉTODOS */
        /* ********************************************************* */
        public void Inicializar()
        {
            Exception Error = null;
            DataSet ODS = OLogicaBD.ProcedimientoAlmacenado("spu_AlumnosSelect", out Error);
            if (Error == null)
            {
                dgvEscuelas.DataSource = ODS.Tables[0];
                dgvEscuelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
                MessageBox.Show(Error.Message);
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
