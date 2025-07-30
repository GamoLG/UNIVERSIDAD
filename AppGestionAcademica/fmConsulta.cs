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
    public partial class fmConsulta : Form
    {
        cLogicaBD OLogicaBD;
        string NombreSP;
        int FilaActual = -1;
        /* **************************************************************** */
        public fmConsulta(SqlConnection OConexionBD_, string Titulo, string NombreSP_)
        {
            InitializeComponent();
            OLogicaBD = new cLogicaBD(OConexionBD_);
            laTitulo.Text = Titulo;
            NombreSP = NombreSP_;            
            ProcesarConsulta();
        }
        /* **************************************************************** */
        public void ProcesarConsulta()
        {
            Exception Error = null;
            DataSet ODS = OLogicaBD.ProcedimientoAlmacenado(NombreSP, out Error);
            if (Error == null)
            {
                dgvConsulta.DataSource = ODS.Tables[0];
                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
                MessageBox.Show(Error.Message);
        }
        /* **************************************************************** */
        public DataGridViewRow FilaDatos()
        {
            if (FilaActual != -1 && FilaActual >= 0)
                return dgvConsulta.Rows[FilaActual];
            else
                return null;
        }
        /* *************************   EVENTOS  ******************************* */
        private void dgvEscuelas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FilaActual = e.RowIndex;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buRecuperar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.CurrentRow != null)
                FilaActual = dgvConsulta.CurrentRow.Index;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
