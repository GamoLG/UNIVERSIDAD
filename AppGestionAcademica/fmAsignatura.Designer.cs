
namespace AppGestionAcademica
{
    partial class fmAsignatura
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
            this.nuCreditos = new System.Windows.Forms.NumericUpDown();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre_Asignatura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCod_Asignatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paInf = new System.Windows.Forms.Panel();
            this.buEliminar = new System.Windows.Forms.Button();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.paSup = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.paDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCreditos)).BeginInit();
            this.paInf.SuspendLayout();
            this.paSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.nuCreditos);
            this.paDatos.Controls.Add(this.cbCategoria);
            this.paDatos.Controls.Add(this.label4);
            this.paDatos.Controls.Add(this.tbNombre_Asignatura);
            this.paDatos.Controls.Add(this.label5);
            this.paDatos.Controls.Add(this.tbCod_Asignatura);
            this.paDatos.Controls.Add(this.label2);
            this.paDatos.Controls.Add(this.label1);
            this.paDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paDatos.Location = new System.Drawing.Point(0, 59);
            this.paDatos.Name = "paDatos";
            this.paDatos.Size = new System.Drawing.Size(800, 331);
            this.paDatos.TabIndex = 5;
            // 
            // nuCreditos
            // 
            this.nuCreditos.Location = new System.Drawing.Point(232, 194);
            this.nuCreditos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuCreditos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuCreditos.Name = "nuCreditos";
            this.nuCreditos.Size = new System.Drawing.Size(56, 22);
            this.nuCreditos.TabIndex = 10;
            this.nuCreditos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "EG",
            "OE",
            "EE",
            "SEM",
            "PPP"});
            this.cbCategoria.Location = new System.Drawing.Point(232, 139);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbCategoria.TabIndex = 9;
            this.cbCategoria.Text = "OE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoría:";
            // 
            // tbNombre_Asignatura
            // 
            this.tbNombre_Asignatura.Location = new System.Drawing.Point(232, 90);
            this.tbNombre_Asignatura.Name = "tbNombre_Asignatura";
            this.tbNombre_Asignatura.Size = new System.Drawing.Size(487, 22);
            this.tbNombre_Asignatura.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre:";
            // 
            // tbCod_Asignatura
            // 
            this.tbCod_Asignatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCod_Asignatura.Location = new System.Drawing.Point(232, 43);
            this.tbCod_Asignatura.Name = "tbCod_Asignatura";
            this.tbCod_Asignatura.Size = new System.Drawing.Size(100, 22);
            this.tbCod_Asignatura.TabIndex = 1;
            this.tbCod_Asignatura.Leave += new System.EventHandler(this.tbCod_Asignatura_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Créditos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
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
            this.buEliminar.Location = new System.Drawing.Point(456, 25);
            this.buEliminar.Name = "buEliminar";
            this.buEliminar.Size = new System.Drawing.Size(75, 23);
            this.buEliminar.TabIndex = 4;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ASIGNATURA";
            // 
            // fmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paDatos);
            this.Controls.Add(this.paInf);
            this.Controls.Add(this.paSup);
            this.Name = "fmAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignatura";
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCreditos)).EndInit();
            this.paInf.ResumeLayout(false);
            this.paSup.ResumeLayout(false);
            this.paSup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre_Asignatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCod_Asignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paInf;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel paSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuCreditos;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button buEliminar;
    }
}