
namespace AppGestionAcademica
{
    partial class fmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paBotones = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.paTitulo = new System.Windows.Forms.Panel();
            this.laTitulo = new System.Windows.Forms.Label();
            this.buRecuperar = new System.Windows.Forms.Button();
            this.paBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.paTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // paBotones
            // 
            this.paBotones.Controls.Add(this.buRecuperar);
            this.paBotones.Controls.Add(this.buSalir);
            this.paBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBotones.Location = new System.Drawing.Point(0, 314);
            this.paBotones.Name = "paBotones";
            this.paBotones.Size = new System.Drawing.Size(649, 47);
            this.paBotones.TabIndex = 4;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(562, 14);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 2;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 63);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(649, 298);
            this.dgvConsulta.TabIndex = 2;
            this.dgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscuelas_CellDoubleClick);
            // 
            // paTitulo
            // 
            this.paTitulo.Controls.Add(this.laTitulo);
            this.paTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitulo.Location = new System.Drawing.Point(0, 0);
            this.paTitulo.Name = "paTitulo";
            this.paTitulo.Size = new System.Drawing.Size(649, 63);
            this.paTitulo.TabIndex = 3;
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.laTitulo.Location = new System.Drawing.Point(184, 21);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(80, 29);
            this.laTitulo.TabIndex = 1;
            this.laTitulo.Text = "Título";
            // 
            // buRecuperar
            // 
            this.buRecuperar.Location = new System.Drawing.Point(12, 14);
            this.buRecuperar.Name = "buRecuperar";
            this.buRecuperar.Size = new System.Drawing.Size(107, 23);
            this.buRecuperar.TabIndex = 3;
            this.buRecuperar.Text = "Recuperar";
            this.buRecuperar.UseVisualStyleBackColor = true;
            this.buRecuperar.Click += new System.EventHandler(this.buRecuperar_Click);
            // 
            // fmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.paBotones);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.paTitulo);
            this.Name = "fmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta";
            this.paBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.paTitulo.ResumeLayout(false);
            this.paTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paBotones;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Panel paTitulo;
        private System.Windows.Forms.Label laTitulo;
        private System.Windows.Forms.Button buRecuperar;
    }
}