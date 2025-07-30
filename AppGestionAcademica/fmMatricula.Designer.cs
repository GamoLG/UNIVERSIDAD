
namespace AppGestionAcademica
{
    partial class fmMatricula
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
            this.paInf = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGrabar = new System.Windows.Forms.Button();
            this.paSup = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSemestre = new System.Windows.Forms.TextBox();
            this.coCod_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNombre_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paDatos.SuspendLayout();
            this.paInf.SuspendLayout();
            this.paSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.tbSemestre);
            this.paDatos.Controls.Add(this.label7);
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
            this.paDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.paDatos.Location = new System.Drawing.Point(0, 59);
            this.paDatos.Name = "paDatos";
            this.paDatos.Size = new System.Drawing.Size(885, 107);
            this.paDatos.TabIndex = 5;
            // 
            // tbCod_EP
            // 
            this.tbCod_EP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCod_EP.Location = new System.Drawing.Point(668, 77);
            this.tbCod_EP.Name = "tbCod_EP";
            this.tbCod_EP.ReadOnly = true;
            this.tbCod_EP.Size = new System.Drawing.Size(100, 22);
            this.tbCod_EP.TabIndex = 5;
            this.tbCod_EP.TabStop = false;
            // 
            // tbMaterno
            // 
            this.tbMaterno.Location = new System.Drawing.Point(305, 77);
            this.tbMaterno.Name = "tbMaterno";
            this.tbMaterno.ReadOnly = true;
            this.tbMaterno.Size = new System.Drawing.Size(155, 22);
            this.tbMaterno.TabIndex = 3;
            this.tbMaterno.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido materno:";
            // 
            // tbPaterno
            // 
            this.tbPaterno.Location = new System.Drawing.Point(144, 77);
            this.tbPaterno.Name = "tbPaterno";
            this.tbPaterno.ReadOnly = true;
            this.tbPaterno.Size = new System.Drawing.Size(150, 22);
            this.tbPaterno.TabIndex = 2;
            this.tbPaterno.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Escuela Profesional:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido paterno:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(479, 77);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.ReadOnly = true;
            this.tbNombres.Size = new System.Drawing.Size(167, 22);
            this.tbNombres.TabIndex = 4;
            this.tbNombres.TabStop = false;
            // 
            // tbCod_Alumno
            // 
            this.tbCod_Alumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCod_Alumno.Location = new System.Drawing.Point(15, 77);
            this.tbCod_Alumno.Name = "tbCod_Alumno";
            this.tbCod_Alumno.Size = new System.Drawing.Size(100, 22);
            this.tbCod_Alumno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // paInf
            // 
            this.paInf.Controls.Add(this.buSalir);
            this.paInf.Controls.Add(this.buGrabar);
            this.paInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paInf.Location = new System.Drawing.Point(0, 390);
            this.paInf.Name = "paInf";
            this.paInf.Size = new System.Drawing.Size(885, 60);
            this.paInf.TabIndex = 4;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(693, 25);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            // 
            // buGrabar
            // 
            this.buGrabar.Location = new System.Drawing.Point(21, 25);
            this.buGrabar.Name = "buGrabar";
            this.buGrabar.Size = new System.Drawing.Size(75, 23);
            this.buGrabar.TabIndex = 0;
            this.buGrabar.Text = "Grabar";
            this.buGrabar.UseVisualStyleBackColor = true;
            // 
            // paSup
            // 
            this.paSup.Controls.Add(this.label3);
            this.paSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSup.Location = new System.Drawing.Point(0, 0);
            this.paSup.Name = "paSup";
            this.paSup.Size = new System.Drawing.Size(885, 59);
            this.paSup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "MATRÍCULA";
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coCod_Asignatura,
            this.coNombre_Asignatura,
            this.coCreditos});
            this.dgvAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsignaturas.Location = new System.Drawing.Point(0, 166);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.RowHeadersWidth = 51;
            this.dgvAsignaturas.RowTemplate.Height = 24;
            this.dgvAsignaturas.Size = new System.Drawing.Size(885, 224);
            this.dgvAsignaturas.TabIndex = 6;
            this.dgvAsignaturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaturas_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(248, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Semestre:";
            // 
            // tbSemestre
            // 
            this.tbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemestre.Location = new System.Drawing.Point(365, 16);
            this.tbSemestre.Name = "tbSemestre";
            this.tbSemestre.Size = new System.Drawing.Size(119, 30);
            this.tbSemestre.TabIndex = 1;
            // 
            // coCod_Asignatura
            // 
            this.coCod_Asignatura.HeaderText = "Código";
            this.coCod_Asignatura.MinimumWidth = 6;
            this.coCod_Asignatura.Name = "coCod_Asignatura";
            this.coCod_Asignatura.ToolTipText = "Haga doble click para acceder a CONSULTA de ALUMNOS";
            this.coCod_Asignatura.Width = 90;
            // 
            // coNombre_Asignatura
            // 
            this.coNombre_Asignatura.HeaderText = "Nombre Asignatura";
            this.coNombre_Asignatura.MinimumWidth = 6;
            this.coNombre_Asignatura.Name = "coNombre_Asignatura";
            this.coNombre_Asignatura.ReadOnly = true;
            this.coNombre_Asignatura.Width = 350;
            // 
            // coCreditos
            // 
            this.coCreditos.HeaderText = "Créditos";
            this.coCreditos.MinimumWidth = 6;
            this.coCreditos.Name = "coCreditos";
            this.coCreditos.ReadOnly = true;
            this.coCreditos.Width = 90;
            // 
            // fmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.paDatos);
            this.Controls.Add(this.paInf);
            this.Controls.Add(this.paSup);
            this.Name = "fmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matrícula";
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            this.paInf.ResumeLayout(false);
            this.paSup.ResumeLayout(false);
            this.paSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paDatos;
        private System.Windows.Forms.TextBox tbCod_EP;
        private System.Windows.Forms.TextBox tbMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbCod_Alumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paInf;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGrabar;
        private System.Windows.Forms.Panel paSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSemestre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCod_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNombre_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCreditos;
    }
}