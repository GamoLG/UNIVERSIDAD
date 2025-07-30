namespace AppBibliotecaDigital
{
    partial class fmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdministradores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLectores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevoluciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrestamosActivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistorialPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.quienesSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickAquiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslEstadoBD = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiAdministracion,
            this.tsmiOperaciones,
            this.tsmiReportes,
            this.quienesSomosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalir});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Text = "Sistema";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(96, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsmiAdministracion
            // 
            this.tsmiAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdministradores,
            this.tsmiLectores,
            this.tsmiLibros});
            this.tsmiAdministracion.Name = "tsmiAdministracion";
            this.tsmiAdministracion.Size = new System.Drawing.Size(100, 20);
            this.tsmiAdministracion.Text = "Administración";
            // 
            // tsmiAdministradores
            // 
            this.tsmiAdministradores.Name = "tsmiAdministradores";
            this.tsmiAdministradores.Size = new System.Drawing.Size(180, 22);
            this.tsmiAdministradores.Text = "Administradores";
            this.tsmiAdministradores.Click += new System.EventHandler(this.tsmiAdministradores_Click);
            // 
            // tsmiLectores
            // 
            this.tsmiLectores.Name = "tsmiLectores";
            this.tsmiLectores.Size = new System.Drawing.Size(180, 22);
            this.tsmiLectores.Text = "Lectores";
            this.tsmiLectores.Click += new System.EventHandler(this.tsmiLectores_Click);
            // 
            // tsmiLibros
            // 
            this.tsmiLibros.Name = "tsmiLibros";
            this.tsmiLibros.Size = new System.Drawing.Size(180, 22);
            this.tsmiLibros.Text = "Libros";
            this.tsmiLibros.Click += new System.EventHandler(this.tsmiLibros_Click);
            // 
            // tsmiOperaciones
            // 
            this.tsmiOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrestamos,
            this.tsmiDevoluciones});
            this.tsmiOperaciones.Name = "tsmiOperaciones";
            this.tsmiOperaciones.Size = new System.Drawing.Size(85, 20);
            this.tsmiOperaciones.Text = "Operaciones";
            // 
            // tsmiPrestamos
            // 
            this.tsmiPrestamos.Name = "tsmiPrestamos";
            this.tsmiPrestamos.Size = new System.Drawing.Size(180, 22);
            this.tsmiPrestamos.Text = "Préstamos";
            this.tsmiPrestamos.Click += new System.EventHandler(this.tsmiPrestamos_Click);
            // 
            // tsmiDevoluciones
            // 
            this.tsmiDevoluciones.Name = "tsmiDevoluciones";
            this.tsmiDevoluciones.Size = new System.Drawing.Size(180, 22);
            this.tsmiDevoluciones.Text = "Devoluciones";
            this.tsmiDevoluciones.Click += new System.EventHandler(this.tsmiDevoluciones_Click);
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrestamosActivos,
            this.tsmiHistorialPrestamos});
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(65, 20);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiPrestamosActivos
            // 
            this.tsmiPrestamosActivos.Name = "tsmiPrestamosActivos";
            this.tsmiPrestamosActivos.Size = new System.Drawing.Size(192, 22);
            this.tsmiPrestamosActivos.Text = "Préstamos Activos";
            this.tsmiPrestamosActivos.Click += new System.EventHandler(this.tsmiPrestamosActivos_Click);
            // 
            // tsmiHistorialPrestamos
            // 
            this.tsmiHistorialPrestamos.Name = "tsmiHistorialPrestamos";
            this.tsmiHistorialPrestamos.Size = new System.Drawing.Size(192, 22);
            this.tsmiHistorialPrestamos.Text = "Historial de Préstamos";
            this.tsmiHistorialPrestamos.Click += new System.EventHandler(this.tsmiHistorialPrestamos_Click);
            // 
            // quienesSomosToolStripMenuItem
            // 
            this.quienesSomosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickAquiToolStripMenuItem});
            this.quienesSomosToolStripMenuItem.Name = "quienesSomosToolStripMenuItem";
            this.quienesSomosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.quienesSomosToolStripMenuItem.Text = "¿Quienes somos?";
            // 
            // clickAquiToolStripMenuItem
            // 
            this.clickAquiToolStripMenuItem.Name = "clickAquiToolStripMenuItem";
            this.clickAquiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clickAquiToolStripMenuItem.Text = "Click aqui :)";
            this.clickAquiToolStripMenuItem.Click += new System.EventHandler(this.clickAquiToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip,
            this.sslUsuario,
            this.sslFecha,
            this.sslHora,
            this.sslEstadoBD});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(88, 19);
            this.StatusStrip.Text = "Barra de estado";
            // 
            // sslUsuario
            // 
            this.sslUsuario.Name = "sslUsuario";
            this.sslUsuario.Size = new System.Drawing.Size(448, 19);
            this.sslUsuario.Spring = true;
            this.sslUsuario.Text = "Usuario: [Sin conexión]\t";
            // 
            // sslFecha
            // 
            this.sslFecha.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.sslFecha.Name = "sslFecha";
            this.sslFecha.Size = new System.Drawing.Size(98, 19);
            this.sslFecha.Text = "Fecha: --/--/----";
            // 
            // sslHora
            // 
            this.sslHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(79, 19);
            this.sslHora.Text = "Hora: --:--:--";
            // 
            // sslEstadoBD
            // 
            this.sslEstadoBD.BackColor = System.Drawing.Color.LightCoral;
            this.sslEstadoBD.Name = "sslEstadoBD";
            this.sslEstadoBD.Size = new System.Drawing.Size(103, 19);
            this.sslEstadoBD.Text = "BD: Desconectado\t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "BIBLIOTECA DIGITAL LUICHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aplicación para el control de préstamos, devoluciones, gestión de libros y lector" +
    "es";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Versión 10.9 - © 2025 Biblioteca Digital";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppBibliotecaDigital.Properties.Resources.logo_biblioteca__1_;
            this.pictureBox2.Location = new System.Drawing.Point(267, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 252);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(829, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Digital - Menú Principal";
            this.Load += new System.EventHandler(this.fmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdministracion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdministradores;
        private System.Windows.Forms.ToolStripMenuItem tsmiLectores;
        private System.Windows.Forms.ToolStripMenuItem tsmiLibros;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrestamos;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevoluciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrestamosActivos;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistorialPrestamos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sslFecha;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
        private System.Windows.Forms.ToolStripStatusLabel sslEstadoBD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem quienesSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickAquiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}