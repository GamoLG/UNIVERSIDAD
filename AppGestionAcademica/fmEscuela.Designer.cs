
namespace AppGestionAcademica
{
    partial class fmEscuela
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
            this.paDatos = new System.Windows.Forms.Panel();
            this.tbNombre_EP = new System.Windows.Forms.TextBox();
            this.tbCod_EP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paSup = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buGrabar = new System.Windows.Forms.Button();
            this.paInf = new System.Windows.Forms.Panel();
            this.buEliminar = new System.Windows.Forms.Button();
            this.buSalir = new System.Windows.Forms.Button();
            this.paDatos.SuspendLayout();
            this.paSup.SuspendLayout();
            this.paInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.tbNombre_EP);
            this.paDatos.Controls.Add(this.tbCod_EP);
            this.paDatos.Controls.Add(this.label2);
            this.paDatos.Controls.Add(this.label1);
            this.paDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paDatos.Location = new System.Drawing.Point(0, 59);
            this.paDatos.Name = "paDatos";
            this.paDatos.Size = new System.Drawing.Size(800, 331);
            this.paDatos.TabIndex = 5;
            // 
            // tbNombre_EP
            // 
            this.tbNombre_EP.Location = new System.Drawing.Point(173, 170);
            this.tbNombre_EP.Name = "tbNombre_EP";
            this.tbNombre_EP.Size = new System.Drawing.Size(404, 22);
            this.tbNombre_EP.TabIndex = 3;
            // 
            // tbCod_EP
            // 
            this.tbCod_EP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCod_EP.Location = new System.Drawing.Point(173, 66);
            this.tbCod_EP.Name = "tbCod_EP";
            this.tbCod_EP.Size = new System.Drawing.Size(100, 22);
            this.tbCod_EP.TabIndex = 2;
            this.tbCod_EP.Leave += new System.EventHandler(this.tbCod_EP_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // paSup
            // 
            this.paSup.Controls.Add(this.label3);
            this.paSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSup.Location = new System.Drawing.Point(0, 0);
            this.paSup.Name = "paSup";
            this.paSup.Size = new System.Drawing.Size(800, 59);
            this.paSup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(198, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Catálogo de Escuelas Profesionales";
            // 
            // buGrabar
            // 
            this.buGrabar.Location = new System.Drawing.Point(21, 25);
            this.buGrabar.Name = "buGrabar";
            this.buGrabar.Size = new System.Drawing.Size(75, 23);
            this.buGrabar.TabIndex = 0;
            this.buGrabar.Text = "Grabar";
            this.buGrabar.UseVisualStyleBackColor = true;
            this.buGrabar.Click += new System.EventHandler(this.buGrabar_Click);
            // 
            // paInf
            // 
            this.paInf.Controls.Add(this.buEliminar);
            this.paInf.Controls.Add(this.buSalir);
            this.paInf.Controls.Add(this.buGrabar);
            this.paInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paInf.Location = new System.Drawing.Point(0, 390);
            this.paInf.Name = "paInf";
            this.paInf.Size = new System.Drawing.Size(800, 60);
            this.paInf.TabIndex = 4;
            // 
            // buEliminar
            // 
            this.buEliminar.Location = new System.Drawing.Point(435, 25);
            this.buEliminar.Name = "buEliminar";
            this.buEliminar.Size = new System.Drawing.Size(75, 23);
            this.buEliminar.TabIndex = 2;
            this.buEliminar.Text = "Eliminar";
            this.buEliminar.UseVisualStyleBackColor = true;
            this.buEliminar.Click += new System.EventHandler(this.buEliminar_Click);
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(693, 25);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // fmEscuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paDatos);
            this.Controls.Add(this.paSup);
            this.Controls.Add(this.paInf);
            this.Name = "fmEscuela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESCUELAS PROFESIONALES";
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            this.paSup.ResumeLayout(false);
            this.paSup.PerformLayout();
            this.paInf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paDatos;
        private System.Windows.Forms.TextBox tbNombre_EP;
        private System.Windows.Forms.TextBox tbCod_EP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel paInf;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buEliminar;
    }
}