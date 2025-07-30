namespace AppBibliotecaDigital
{
    partial class fmPrestamosActivos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cboFiltrarLector = new System.Windows.Forms.ComboBox();
            this.lblFiltrarLibro = new System.Windows.Forms.Label();
            this.cboFiltrarLibro = new System.Windows.Forms.ComboBox();
            this.lblFiltrarLector = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslCantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reporte de Préstamos Activos";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.RosyBrown;
            this.gbFiltros.Controls.Add(this.cboFiltrarLector);
            this.gbFiltros.Controls.Add(this.lblFiltrarLibro);
            this.gbFiltros.Controls.Add(this.cboFiltrarLibro);
            this.gbFiltros.Controls.Add(this.lblFiltrarLector);
            this.gbFiltros.Location = new System.Drawing.Point(20, 60);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(760, 84);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // cboFiltrarLector
            // 
            this.cboFiltrarLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarLector.FormattingEnabled = true;
            this.cboFiltrarLector.Location = new System.Drawing.Point(52, 26);
            this.cboFiltrarLector.Name = "cboFiltrarLector";
            this.cboFiltrarLector.Size = new System.Drawing.Size(121, 21);
            this.cboFiltrarLector.TabIndex = 3;
            // 
            // lblFiltrarLibro
            // 
            this.lblFiltrarLibro.AutoSize = true;
            this.lblFiltrarLibro.Location = new System.Drawing.Point(419, 29);
            this.lblFiltrarLibro.Name = "lblFiltrarLibro";
            this.lblFiltrarLibro.Size = new System.Drawing.Size(30, 13);
            this.lblFiltrarLibro.TabIndex = 2;
            this.lblFiltrarLibro.Text = "Libro";
            // 
            // cboFiltrarLibro
            // 
            this.cboFiltrarLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarLibro.FormattingEnabled = true;
            this.cboFiltrarLibro.Location = new System.Drawing.Point(455, 29);
            this.cboFiltrarLibro.Name = "cboFiltrarLibro";
            this.cboFiltrarLibro.Size = new System.Drawing.Size(121, 21);
            this.cboFiltrarLibro.TabIndex = 1;
            // 
            // lblFiltrarLector
            // 
            this.lblFiltrarLector.AutoSize = true;
            this.lblFiltrarLector.Location = new System.Drawing.Point(6, 26);
            this.lblFiltrarLector.Name = "lblFiltrarLector";
            this.lblFiltrarLector.Size = new System.Drawing.Size(40, 13);
            this.lblFiltrarLector.TabIndex = 0;
            this.lblFiltrarLector.Text = "Lector:";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(20, 150);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(760, 250);
            this.dgvPrestamos.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkRed;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Location = new System.Drawing.Point(594, 406);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 30);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarPDF.Location = new System.Drawing.Point(680, 406);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(100, 30);
            this.btnGenerarPDF.TabIndex = 4;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslCantidad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
 
            // 
            // sslCantidad
            // 
            this.sslCantidad.Name = "sslCantidad";
            this.sslCantidad.Size = new System.Drawing.Size(118, 17);
            this.sslCantidad.Text = "Total de préstamos: 0";
            // 
            // fmPrestamosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(822, 469);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "fmPrestamosActivos";
            this.Text = "Reporte de préstamos activos";
            this.Load += new System.EventHandler(this.fmPrestamosActivos_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cboFiltrarLibro;
        private System.Windows.Forms.Label lblFiltrarLector;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.ComboBox cboFiltrarLector;
        private System.Windows.Forms.Label lblFiltrarLibro;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslCantidad;
    }
}