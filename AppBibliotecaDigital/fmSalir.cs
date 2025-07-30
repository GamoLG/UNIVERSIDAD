using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppBibliotecaDigital
{
    public partial class fmSalir : Form
    {
        public fmSalir()
        {
            InitializeComponent();

            // Configura los botones para devolver resultados
            btnAceptar.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        private void fmSalir_Load(object sender, EventArgs e)
        {
            // Centrar los botones horizontalmente
            btnAceptar.Left = (this.ClientSize.Width - btnAceptar.Width - btnCancelar.Width - 20) / 2;
            btnCancelar.Left = btnAceptar.Right + 20;
        }

        // Propiedad opcional (puedes eliminarla si usas solo DialogResult)
        public bool ConfirmarSalida { get; private set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConfirmarSalida = true;
            this.DialogResult = DialogResult.OK; // Establece el resultado del diálogo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfirmarSalida = false;
            this.DialogResult = DialogResult.Cancel; // Establece el resultado del diálogo
        }
    }
}