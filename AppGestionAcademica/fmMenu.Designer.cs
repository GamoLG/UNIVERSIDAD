
namespace AppGestionAcademica
{
    partial class fmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEscuelasProfesionales = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.escuelasProfesionalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.constanciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constanciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OConexionOld = new System.Data.SqlClient.SqlConnection();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.finToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEscuelasProfesionales,
            this.alumnosToolStripMenuItem,
            this.asignaturasToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // miEscuelasProfesionales
            // 
            this.miEscuelasProfesionales.Name = "miEscuelasProfesionales";
            this.miEscuelasProfesionales.Size = new System.Drawing.Size(239, 26);
            this.miEscuelasProfesionales.Text = "Escuelas Profesionales";
            this.miEscuelasProfesionales.Click += new System.EventHandler(this.miEscuelasProfesionales_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem.Click += new System.EventHandler(this.asignaturasToolStripMenuItem_Click);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrículasToolStripMenuItem,
            this.ingresoDeNotasToolStripMenuItem});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.procesoToolStripMenuItem.Text = "Proceso";
            // 
            // matrículasToolStripMenuItem
            // 
            this.matrículasToolStripMenuItem.Name = "matrículasToolStripMenuItem";
            this.matrículasToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.matrículasToolStripMenuItem.Text = "Matrículas";
            this.matrículasToolStripMenuItem.Click += new System.EventHandler(this.matrículasToolStripMenuItem_Click);
            // 
            // ingresoDeNotasToolStripMenuItem
            // 
            this.ingresoDeNotasToolStripMenuItem.Name = "ingresoDeNotasToolStripMenuItem";
            this.ingresoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.ingresoDeNotasToolStripMenuItem.Text = "Ingreso de notas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem1,
            this.constanciasToolStripMenuItem,
            this.certificadosToolStripMenuItem,
            this.constanciasToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // catálogosToolStripMenuItem1
            // 
            this.catálogosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escuelasProfesionalesToolStripMenuItem1,
            this.alumnosToolStripMenuItem1,
            this.asignaturasToolStripMenuItem1});
            this.catálogosToolStripMenuItem1.Name = "catálogosToolStripMenuItem1";
            this.catálogosToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.catálogosToolStripMenuItem1.Text = "Catálogos";
            // 
            // escuelasProfesionalesToolStripMenuItem1
            // 
            this.escuelasProfesionalesToolStripMenuItem1.Name = "escuelasProfesionalesToolStripMenuItem1";
            this.escuelasProfesionalesToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.escuelasProfesionalesToolStripMenuItem1.Text = "Escuelas Profesionales";
            this.escuelasProfesionalesToolStripMenuItem1.Click += new System.EventHandler(this.escuelasProfesionalesToolStripMenuItem1_Click);
            // 
            // alumnosToolStripMenuItem1
            // 
            this.alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            this.alumnosToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.alumnosToolStripMenuItem1.Text = "Alumnos";
            this.alumnosToolStripMenuItem1.Click += new System.EventHandler(this.alumnosToolStripMenuItem1_Click);
            // 
            // asignaturasToolStripMenuItem1
            // 
            this.asignaturasToolStripMenuItem1.Name = "asignaturasToolStripMenuItem1";
            this.asignaturasToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.asignaturasToolStripMenuItem1.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem1.Click += new System.EventHandler(this.asignaturasToolStripMenuItem1_Click);
            // 
            // constanciasToolStripMenuItem
            // 
            this.constanciasToolStripMenuItem.Name = "constanciasToolStripMenuItem";
            this.constanciasToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.constanciasToolStripMenuItem.Text = "Constancias";
            // 
            // certificadosToolStripMenuItem
            // 
            this.certificadosToolStripMenuItem.Name = "certificadosToolStripMenuItem";
            this.certificadosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.certificadosToolStripMenuItem.Text = "Certificados";
            // 
            // constanciasToolStripMenuItem1
            // 
            this.constanciasToolStripMenuItem1.Name = "constanciasToolStripMenuItem1";
            this.constanciasToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.constanciasToolStripMenuItem1.Text = "Actas";
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            this.finToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.finToolStripMenuItem.Text = "Fin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppGestionAcademica.Properties.Resources.EPIIS;
            this.pictureBox2.Location = new System.Drawing.Point(554, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppGestionAcademica.Properties.Resources.UNSAAC1;
            this.pictureBox1.Location = new System.Drawing.Point(111, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // OConexionOld
            // 
            this.OConexionOld.ConnectionString = "Data Source=DESKTOP-D7UFLKT;Initial Catalog=BD_Gestion_Academica;Integrated Secur" +
    "ity=True";
            this.OConexionOld.FireInfoMessageEventOnUserErrors = false;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 579);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMenu";
            this.Text = "Gestión Académica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEscuelasProfesionales;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem escuelasProfesionalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem constanciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constanciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Data.SqlClient.SqlConnection OConexionOld;
    }
}

