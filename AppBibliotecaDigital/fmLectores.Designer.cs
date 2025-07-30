namespace AppBibliotecaDigital
{
    partial class fmLectores
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
            this.dgvLectores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellidoLector = new System.Windows.Forms.Label();
            this.lblNombreLector = new System.Windows.Forms.Label();
            this.lblCodLector = new System.Windows.Forms.Label();
            this.btnCancelarLector = new System.Windows.Forms.Button();
            this.btnEliminarLector = new System.Windows.Forms.Button();
            this.btnGuardarLector = new System.Windows.Forms.Button();
            this.btnNuevoLector = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidoLector = new System.Windows.Forms.TextBox();
            this.txtNombreLector = new System.Windows.Forms.TextBox();
            this.txtCodLector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLectores
            // 
            this.dgvLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectores.Location = new System.Drawing.Point(12, 47);
            this.dgvLectores.Name = "dgvLectores";
            this.dgvLectores.Size = new System.Drawing.Size(514, 304);
            this.dgvLectores.TabIndex = 0;
            this.dgvLectores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLectores_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.lblApellidoLector);
            this.groupBox1.Controls.Add(this.lblNombreLector);
            this.groupBox1.Controls.Add(this.lblCodLector);
            this.groupBox1.Controls.Add(this.btnCancelarLector);
            this.groupBox1.Controls.Add(this.btnEliminarLector);
            this.groupBox1.Controls.Add(this.btnGuardarLector);
            this.groupBox1.Controls.Add(this.btnNuevoLector);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtApellidoLector);
            this.groupBox1.Controls.Add(this.txtNombreLector);
            this.groupBox1.Controls.Add(this.txtCodLector);
            this.groupBox1.Location = new System.Drawing.Point(532, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Lector";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(84, 187);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(84, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(84, 135);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(84, 109);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 14;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellidoLector
            // 
            this.lblApellidoLector.AutoSize = true;
            this.lblApellidoLector.Location = new System.Drawing.Point(84, 83);
            this.lblApellidoLector.Name = "lblApellidoLector";
            this.lblApellidoLector.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoLector.TabIndex = 13;
            this.lblApellidoLector.Text = "Apellido:";
            // 
            // lblNombreLector
            // 
            this.lblNombreLector.AutoSize = true;
            this.lblNombreLector.Location = new System.Drawing.Point(84, 57);
            this.lblNombreLector.Name = "lblNombreLector";
            this.lblNombreLector.Size = new System.Drawing.Size(47, 13);
            this.lblNombreLector.TabIndex = 12;
            this.lblNombreLector.Text = "Nombre:";
            // 
            // lblCodLector
            // 
            this.lblCodLector.AutoSize = true;
            this.lblCodLector.Location = new System.Drawing.Point(84, 35);
            this.lblCodLector.Name = "lblCodLector";
            this.lblCodLector.Size = new System.Drawing.Size(43, 13);
            this.lblCodLector.TabIndex = 11;
            this.lblCodLector.Text = "Código:";
            // 
            // btnCancelarLector
            // 
            this.btnCancelarLector.Location = new System.Drawing.Point(252, 259);
            this.btnCancelarLector.Name = "btnCancelarLector";
            this.btnCancelarLector.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLector.TabIndex = 10;
            this.btnCancelarLector.Text = "Cancelar ";
            this.btnCancelarLector.UseVisualStyleBackColor = true;
            this.btnCancelarLector.Click += new System.EventHandler(this.btnCancelarLector_Click);
            // 
            // btnEliminarLector
            // 
            this.btnEliminarLector.Location = new System.Drawing.Point(171, 259);
            this.btnEliminarLector.Name = "btnEliminarLector";
            this.btnEliminarLector.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLector.TabIndex = 9;
            this.btnEliminarLector.Text = "Eliminar ";
            this.btnEliminarLector.UseVisualStyleBackColor = true;
            this.btnEliminarLector.Click += new System.EventHandler(this.btnEliminarLector_Click);
            // 
            // btnGuardarLector
            // 
            this.btnGuardarLector.Location = new System.Drawing.Point(87, 259);
            this.btnGuardarLector.Name = "btnGuardarLector";
            this.btnGuardarLector.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLector.TabIndex = 8;
            this.btnGuardarLector.Text = "Guardar ";
            this.btnGuardarLector.UseVisualStyleBackColor = true;
            this.btnGuardarLector.Click += new System.EventHandler(this.btnGuardarLector_Click);
            // 
            // btnNuevoLector
            // 
            this.btnNuevoLector.Location = new System.Drawing.Point(6, 259);
            this.btnNuevoLector.Name = "btnNuevoLector";
            this.btnNuevoLector.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoLector.TabIndex = 7;
            this.btnNuevoLector.Text = "Nuevo ";
            this.btnNuevoLector.UseVisualStyleBackColor = true;
            this.btnNuevoLector.Click += new System.EventHandler(this.btnNuevoLector_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(146, 184);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(131, 21);
            this.cmbEstado.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(146, 132);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(146, 106);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(131, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // txtApellidoLector
            // 
            this.txtApellidoLector.Location = new System.Drawing.Point(146, 80);
            this.txtApellidoLector.Name = "txtApellidoLector";
            this.txtApellidoLector.Size = new System.Drawing.Size(131, 20);
            this.txtApellidoLector.TabIndex = 2;
            // 
            // txtNombreLector
            // 
            this.txtNombreLector.Location = new System.Drawing.Point(146, 54);
            this.txtNombreLector.Name = "txtNombreLector";
            this.txtNombreLector.Size = new System.Drawing.Size(131, 20);
            this.txtNombreLector.TabIndex = 1;
            // 
            // txtCodLector
            // 
            this.txtCodLector.Location = new System.Drawing.Point(146, 28);
            this.txtCodLector.Name = "txtCodLector";
            this.txtCodLector.Size = new System.Drawing.Size(131, 20);
            this.txtCodLector.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "CÁTALOGO DE LECTORES";
            // 
            // fmLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 471);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLectores);
            this.Name = "fmLectores";
            this.Text = "Catálogo lectores";
            this.Load += new System.EventHandler(this.fmLectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLectores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidoLector;
        private System.Windows.Forms.TextBox txtNombreLector;
        private System.Windows.Forms.TextBox txtCodLector;
        private System.Windows.Forms.Button btnCancelarLector;
        private System.Windows.Forms.Button btnEliminarLector;
        private System.Windows.Forms.Button btnGuardarLector;
        private System.Windows.Forms.Button btnNuevoLector;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellidoLector;
        private System.Windows.Forms.Label lblNombreLector;
        private System.Windows.Forms.Label lblCodLector;
        private System.Windows.Forms.Label label6;
    }
}