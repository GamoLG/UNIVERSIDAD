namespace AppBibliotecaDigital
{
    partial class fmDevoluciones
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
            this.dgvPrestamosActivos = new System.Windows.Forms.DataGridView();
            this.gbDatosDevolucion = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesarDevolucion = new System.Windows.Forms.Button();
            this.txtDiasTranscurridos = new System.Windows.Forms.TextBox();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtLector = new System.Windows.Forms.TextBox();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).BeginInit();
            this.gbDatosDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestamosActivos
            // 
            this.dgvPrestamosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosActivos.Location = new System.Drawing.Point(12, 42);
            this.dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            this.dgvPrestamosActivos.Size = new System.Drawing.Size(528, 381);
            this.dgvPrestamosActivos.TabIndex = 0;
            this.dgvPrestamosActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamosActivos_CellClick);
            // 
            // gbDatosDevolucion
            // 
            this.gbDatosDevolucion.BackColor = System.Drawing.Color.Tan;
            this.gbDatosDevolucion.Controls.Add(this.cmbEstado);
            this.gbDatosDevolucion.Controls.Add(this.btnActualizar);
            this.gbDatosDevolucion.Controls.Add(this.btnCancelar);
            this.gbDatosDevolucion.Controls.Add(this.btnProcesarDevolucion);
            this.gbDatosDevolucion.Controls.Add(this.txtDiasTranscurridos);
            this.gbDatosDevolucion.Controls.Add(this.txtFechaPrestamo);
            this.gbDatosDevolucion.Controls.Add(this.txtLibro);
            this.gbDatosDevolucion.Controls.Add(this.txtLector);
            this.gbDatosDevolucion.Controls.Add(this.txtIdPrestamo);
            this.gbDatosDevolucion.Controls.Add(this.label6);
            this.gbDatosDevolucion.Controls.Add(this.label5);
            this.gbDatosDevolucion.Controls.Add(this.label4);
            this.gbDatosDevolucion.Controls.Add(this.label3);
            this.gbDatosDevolucion.Controls.Add(this.label2);
            this.gbDatosDevolucion.Controls.Add(this.label1);
            this.gbDatosDevolucion.Location = new System.Drawing.Point(546, 42);
            this.gbDatosDevolucion.Name = "gbDatosDevolucion";
            this.gbDatosDevolucion.Size = new System.Drawing.Size(348, 317);
            this.gbDatosDevolucion.TabIndex = 1;
            this.gbDatosDevolucion.TabStop = false;
            this.gbDatosDevolucion.Text = "Datos de Devolución";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(142, 211);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 15;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(247, 264);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 39);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar Lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(128, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesarDevolucion
            // 
            this.btnProcesarDevolucion.Location = new System.Drawing.Point(6, 264);
            this.btnProcesarDevolucion.Name = "btnProcesarDevolucion";
            this.btnProcesarDevolucion.Size = new System.Drawing.Size(73, 47);
            this.btnProcesarDevolucion.TabIndex = 12;
            this.btnProcesarDevolucion.Text = "Procesar Devolución";
            this.btnProcesarDevolucion.UseVisualStyleBackColor = true;
            this.btnProcesarDevolucion.Click += new System.EventHandler(this.btnProcesarDevolucion_Click);
            // 
            // txtDiasTranscurridos
            // 
            this.txtDiasTranscurridos.Location = new System.Drawing.Point(142, 178);
            this.txtDiasTranscurridos.Name = "txtDiasTranscurridos";
            this.txtDiasTranscurridos.ReadOnly = true;
            this.txtDiasTranscurridos.Size = new System.Drawing.Size(100, 20);
            this.txtDiasTranscurridos.TabIndex = 11;
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Location = new System.Drawing.Point(142, 146);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.ReadOnly = true;
            this.txtFechaPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPrestamo.TabIndex = 10;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(142, 116);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(100, 20);
            this.txtLibro.TabIndex = 9;
            // 
            // txtLector
            // 
            this.txtLector.Location = new System.Drawing.Point(142, 90);
            this.txtLector.Name = "txtLector";
            this.txtLector.ReadOnly = true;
            this.txtLector.Size = new System.Drawing.Size(100, 20);
            this.txtLector.TabIndex = 8;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(142, 57);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.ReadOnly = true;
            this.txtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DiasTranscurridos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FechaPrestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gestión de Devoluciones";
            // 
            // fmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbDatosDevolucion);
            this.Controls.Add(this.dgvPrestamosActivos);
            this.Name = "fmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Devoluciones";
            this.Load += new System.EventHandler(this.fmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).EndInit();
            this.gbDatosDevolucion.ResumeLayout(false);
            this.gbDatosDevolucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamosActivos;
        private System.Windows.Forms.GroupBox gbDatosDevolucion;
        private System.Windows.Forms.TextBox txtDiasTranscurridos;
        private System.Windows.Forms.TextBox txtFechaPrestamo;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtLector;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesarDevolucion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
    }
}