
namespace AppGestionAcademica
{
    partial class fmReporteEscuelas
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
            this.paTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.paBotones = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.paDatos = new System.Windows.Forms.Panel();
            this.dgvEscuelas = new System.Windows.Forms.DataGridView();
            this.paTitulo.SuspendLayout();
            this.paBotones.SuspendLayout();
            this.paDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).BeginInit();
            this.SuspendLayout();
            // 
            // paTitulo
            // 
            this.paTitulo.Controls.Add(this.label3);
            this.paTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitulo.Location = new System.Drawing.Point(0, 0);
            this.paTitulo.Name = "paTitulo";
            this.paTitulo.Size = new System.Drawing.Size(800, 63);
            this.paTitulo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(234, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Escuelas Profesionales";
            // 
            // paBotones
            // 
            this.paBotones.Controls.Add(this.buSalir);
            this.paBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBotones.Location = new System.Drawing.Point(0, 388);
            this.paBotones.Name = "paBotones";
            this.paBotones.Size = new System.Drawing.Size(800, 62);
            this.paBotones.TabIndex = 1;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(363, 20);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 2;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.dgvEscuelas);
            this.paDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paDatos.Location = new System.Drawing.Point(0, 63);
            this.paDatos.Name = "paDatos";
            this.paDatos.Size = new System.Drawing.Size(800, 325);
            this.paDatos.TabIndex = 2;
            // 
            // dgvEscuelas
            // 
            this.dgvEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscuelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEscuelas.Location = new System.Drawing.Point(0, 0);
            this.dgvEscuelas.Name = "dgvEscuelas";
            this.dgvEscuelas.RowHeadersWidth = 51;
            this.dgvEscuelas.RowTemplate.Height = 24;
            this.dgvEscuelas.Size = new System.Drawing.Size(800, 325);
            this.dgvEscuelas.TabIndex = 0;
            // 
            // fmReporteEscuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paDatos);
            this.Controls.Add(this.paBotones);
            this.Controls.Add(this.paTitulo);
            this.Name = "fmReporteEscuelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESCUELAS";
            this.paTitulo.ResumeLayout(false);
            this.paTitulo.PerformLayout();
            this.paBotones.ResumeLayout(false);
            this.paDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paTitulo;
        private System.Windows.Forms.Panel paBotones;
        private System.Windows.Forms.Panel paDatos;
        private System.Windows.Forms.DataGridView dgvEscuelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buSalir;
    }
}