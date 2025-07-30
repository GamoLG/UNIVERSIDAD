
namespace AppGestionAcademica
{
    partial class fmAlumno
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
            this.paSup = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.paInf = new System.Windows.Forms.Panel();
            this.buEliminar = new System.Windows.Forms.Button();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.paDatos = new System.Windows.Forms.Panel();
            this.laNombre_CP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCod_EP = new System.Windows.Forms.TextBox();
            this.tbMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbCod_Alumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paSup.SuspendLayout();
            this.paInf.SuspendLayout();
            this.paDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paSup
            // 
            this.paSup.Controls.Add(this.label3);
            this.paSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSup.Location = new System.Drawing.Point(0, 0);
            this.paSup.Name = "paSup";
            this.paSup.Size = new System.Drawing.Size(800, 59);
            this.paSup.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALUMNOS";
            // 
            // paInf
            // 
            this.paInf.Controls.Add(this.buEliminar);
            this.paInf.Controls.Add(this.buSalir);
            this.paInf.Controls.Add(this.buGrabar);
            this.paInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paInf.Location = new System.Drawing.Point(0, 396);
            this.paInf.Name = "paInf";
            this.paInf.Size = new System.Drawing.Size(800, 54);
            this.paInf.TabIndex = 1;
            // 
            // buEliminar
            // 
            this.buEliminar.Location = new System.Drawing.Point(429, 16);
            this.buEliminar.Name = "buEliminar";
            this.buEliminar.Size = new System.Drawing.Size(75, 23);
            this.buEliminar.TabIndex = 3;
            this.buEliminar.Text = "Eliminar";
            this.buEliminar.UseVisualStyleBackColor = true;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(693, 16);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // buGrabar
            // 
            this.buGrabar.Location = new System.Drawing.Point(21, 16);
            this.buGrabar.Name = "buGrabar";
            this.buGrabar.Size = new System.Drawing.Size(75, 23);
            this.buGrabar.TabIndex = 0;
            this.buGrabar.Text = "Grabar";
            this.buGrabar.UseVisualStyleBackColor = true;
            this.buGrabar.Click += new System.EventHandler(this.buGrabar_Click);
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.laNombre_CP);
            this.paDatos.Controls.Add(this.button1);
            this.paDatos.Controls.Add(this.tbCod_EP);
            this.paDatos.Controls.Add(this.tbMaterno);
            this.paDatos.Controls.Add(this.label4);
            this.paDatos.Controls.Add(this.tbPaterno);
            this.paDatos.Controls.Add(this.label6);
            this.paDatos.Controls.Add(this.label5);
            this.paDatos.Controls.Add(this.tbNombres);
            this.paDatos.Controls.Add(this.tbCod_Alumno);
            this.paDatos.Controls.Add(this.label2);
            this.paDatos.Controls.Add(this.label1);
            this.paDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paDatos.Location = new System.Drawing.Point(0, 59);
            this.paDatos.Name = "paDatos";
            this.paDatos.Size = new System.Drawing.Size(800, 337);
            this.paDatos.TabIndex = 2;
            // 
            // laNombre_CP
            // 
            this.laNombre_CP.AutoSize = true;
            this.laNombre_CP.Location = new System.Drawing.Point(378, 264);
            this.laNombre_CP.Name = "laNombre_CP";
            this.laNombre_CP.Size = new System.Drawing.Size(20, 17);
            this.laNombre_CP.TabIndex = 10;
            this.laNombre_CP.Text = "   ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCod_EP
            // 
            this.tbCod_EP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCod_EP.Location = new System.Drawing.Point(232, 259);
            this.tbCod_EP.Name = "tbCod_EP";
            this.tbCod_EP.Size = new System.Drawing.Size(100, 22);
            this.tbCod_EP.TabIndex = 5;
            // 
            // tbMaterno
            // 
            this.tbMaterno.Location = new System.Drawing.Point(232, 141);
            this.tbMaterno.Name = "tbMaterno";
            this.tbMaterno.Size = new System.Drawing.Size(245, 22);
            this.tbMaterno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido materno:";
            // 
            // tbPaterno
            // 
            this.tbPaterno.Location = new System.Drawing.Point(232, 90);
            this.tbPaterno.Name = "tbPaterno";
            this.tbPaterno.Size = new System.Drawing.Size(245, 22);
            this.tbPaterno.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Escuela Profesional:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido paterno:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(232, 193);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(245, 22);
            this.tbNombres.TabIndex = 4;
            // 
            // tbCod_Alumno
            // 
            this.tbCod_Alumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCod_Alumno.Location = new System.Drawing.Point(232, 43);
            this.tbCod_Alumno.Name = "tbCod_Alumno";
            this.tbCod_Alumno.Size = new System.Drawing.Size(100, 22);
            this.tbCod_Alumno.TabIndex = 1;
            this.tbCod_Alumno.Leave += new System.EventHandler(this.tbCod_Alumno_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
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
            // fmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paDatos);
            this.Controls.Add(this.paInf);
            this.Controls.Add(this.paSup);
            this.Name = "fmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ALUMNOS";
            this.paSup.ResumeLayout(false);
            this.paSup.PerformLayout();
            this.paInf.ResumeLayout(false);
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paSup;
        private System.Windows.Forms.Panel paInf;
        private System.Windows.Forms.Panel paDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbCod_Alumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCod_EP;
        private System.Windows.Forms.TextBox tbMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPaterno;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buEliminar;
        private System.Windows.Forms.Label laNombre_CP;
    }
}