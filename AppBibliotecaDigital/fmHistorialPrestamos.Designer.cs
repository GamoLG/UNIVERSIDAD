namespace AppBibliotecaDigital
{
    partial class fmHistorialPrestamos
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
            this.lblFiltrarLector = new System.Windows.Forms.Label();
            this.cboFiltrarLector = new System.Windows.Forms.ComboBox();
            this.lblFiltrarLibro = new System.Windows.Forms.Label();
            this.cboFiltrarLibro = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslCantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(255, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historial de Préstamos";
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.LightSalmon;
            this.gbFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.gbFiltros.Controls.Add(this.btnGenerarPDF);
            this.gbFiltros.Controls.Add(this.cboFiltrarLibro);
            this.gbFiltros.Controls.Add(this.lblFiltrarLibro);
            this.gbFiltros.Controls.Add(this.cboFiltrarLector);
            this.gbFiltros.Controls.Add(this.lblFiltrarLector);
            this.gbFiltros.Location = new System.Drawing.Point(668, 56);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(238, 204);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "FILTROS";
            // 
            // lblFiltrarLector
            // 
            this.lblFiltrarLector.AutoSize = true;
            this.lblFiltrarLector.Location = new System.Drawing.Point(16, 38);
            this.lblFiltrarLector.Name = "lblFiltrarLector";
            this.lblFiltrarLector.Size = new System.Drawing.Size(40, 13);
            this.lblFiltrarLector.TabIndex = 0;
            this.lblFiltrarLector.Text = "Lector:";
            // 
            // cboFiltrarLector
            // 
            this.cboFiltrarLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarLector.FormattingEnabled = true;
            this.cboFiltrarLector.Location = new System.Drawing.Point(62, 38);
            this.cboFiltrarLector.Name = "cboFiltrarLector";
            this.cboFiltrarLector.Size = new System.Drawing.Size(121, 21);
            this.cboFiltrarLector.TabIndex = 1;
            // 
            // lblFiltrarLibro
            // 
            this.lblFiltrarLibro.AutoSize = true;
            this.lblFiltrarLibro.Location = new System.Drawing.Point(16, 78);
            this.lblFiltrarLibro.Name = "lblFiltrarLibro";
            this.lblFiltrarLibro.Size = new System.Drawing.Size(33, 13);
            this.lblFiltrarLibro.TabIndex = 2;
            this.lblFiltrarLibro.Text = "Libro:";
            // 
            // cboFiltrarLibro
            // 
            this.cboFiltrarLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarLibro.FormattingEnabled = true;
            this.cboFiltrarLibro.Location = new System.Drawing.Point(62, 75);
            this.cboFiltrarLibro.Name = "cboFiltrarLibro";
            this.cboFiltrarLibro.Size = new System.Drawing.Size(121, 21);
            this.cboFiltrarLibro.TabIndex = 3;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(19, 128);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(85, 32);
            this.btnLimpiarFiltros.TabIndex = 4;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 56);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(636, 365);
            this.dgvHistorial.TabIndex = 2;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(119, 128);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(104, 43);
            this.btnGenerarPDF.TabIndex = 3;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslCantidad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslCantidad
            // 
            this.sslCantidad.Name = "sslCantidad";
            this.sslCantidad.Size = new System.Drawing.Size(87, 17);
            this.sslCantidad.Text = "otal registros: 0";
            // 
            // fmHistorialPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmHistorialPrestamos";
            this.Text = "Historial de Préstamos";
            this.Load += new System.EventHandler(this.fmHistorialPrestamos_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.ComboBox cboFiltrarLibro;
        private System.Windows.Forms.Label lblFiltrarLibro;
        private System.Windows.Forms.ComboBox cboFiltrarLector;
        private System.Windows.Forms.Label lblFiltrarLector;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslCantidad;
    }
}