﻿
namespace CapaVista.Mantenimientos
{
    partial class frmCliente
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMuni = new System.Windows.Forms.TextBox();
            this.txtDepar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.cmbDepar = new System.Windows.Forms.ComboBox();
            this.cmbMuni = new System.Windows.Forms.ComboBox();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(159, 230);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 23);
            this.txtDireccion.TabIndex = 70;
            this.txtDireccion.Tag = "direccionCliente";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(159, 196);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 23);
            this.txtApellido.TabIndex = 69;
            this.txtApellido.Tag = "apellidoCliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(159, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 23);
            this.txtNombre.TabIndex = 68;
            this.txtNombre.Tag = "nombreCliente";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(159, 127);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(196, 23);
            this.txtCliente.TabIndex = 67;
            this.txtCliente.Tag = "pkIdCliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(83, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(88, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(92, 166);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(61, 17);
            this.Nombre.TabIndex = 64;
            this.Nombre.Tag = "";
            this.Nombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(79, 130);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 17);
            this.lblId.TabIndex = 63;
            this.lblId.Text = "ID Cliente";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 90);
            this.navegador1.TabIndex = 62;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(159, 366);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(197, 23);
            this.txtNit.TabIndex = 78;
            this.txtNit.Tag = "nitCliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(159, 337);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(197, 23);
            this.txtCodigo.TabIndex = 77;
            this.txtCodigo.Tag = "codigoPostal";
            // 
            // txtMuni
            // 
            this.txtMuni.Enabled = false;
            this.txtMuni.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuni.Location = new System.Drawing.Point(159, 303);
            this.txtMuni.Name = "txtMuni";
            this.txtMuni.Size = new System.Drawing.Size(43, 23);
            this.txtMuni.TabIndex = 76;
            this.txtMuni.Tag = "fkIdMuni";
            // 
            // txtDepar
            // 
            this.txtDepar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepar.Location = new System.Drawing.Point(159, 266);
            this.txtDepar.Name = "txtDepar";
            this.txtDepar.Size = new System.Drawing.Size(44, 23);
            this.txtDepar.TabIndex = 75;
            this.txtDepar.Tag = "fkIdDepar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nit Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Codigo Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(62, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "ID Municipio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "ID Departamento";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(23, 436);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(59, 23);
            this.txtEstado.TabIndex = 82;
            this.txtEstado.Tag = "estadoCliente";
            this.txtEstado.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(159, 395);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 23);
            this.txtTelefono.TabIndex = 81;
            this.txtTelefono.Tag = "telCliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(88, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(88, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Telefono";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(382, 127);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.Size = new System.Drawing.Size(655, 328);
            this.dgvCliente.TabIndex = 83;
            // 
            // cmbDepar
            // 
            this.cmbDepar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepar.FormattingEnabled = true;
            this.cmbDepar.Location = new System.Drawing.Point(212, 266);
            this.cmbDepar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepar.Name = "cmbDepar";
            this.cmbDepar.Size = new System.Drawing.Size(144, 25);
            this.cmbDepar.TabIndex = 84;
            this.cmbDepar.Tag = "saltar";
            this.cmbDepar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbMuni
            // 
            this.cmbMuni.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMuni.FormattingEnabled = true;
            this.cmbMuni.Location = new System.Drawing.Point(212, 301);
            this.cmbMuni.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMuni.Name = "cmbMuni";
            this.cmbMuni.Size = new System.Drawing.Size(143, 25);
            this.cmbMuni.TabIndex = 85;
            this.cmbMuni.Tag = "saltar";
            this.cmbMuni.SelectedIndexChanged += new System.EventHandler(this.cmbMuni_SelectedIndexChanged);
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbDeshabilitado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeshabilitado.ForeColor = System.Drawing.Color.Black;
            this.rbDeshabilitado.Location = new System.Drawing.Point(242, 434);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(114, 21);
            this.rbDeshabilitado.TabIndex = 87;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = false;
            this.rbDeshabilitado.CheckedChanged += new System.EventHandler(this.rbDeshabilitado_CheckedChanged);
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbHabilitado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHabilitado.ForeColor = System.Drawing.Color.Black;
            this.rbHabilitado.Location = new System.Drawing.Point(144, 434);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(92, 21);
            this.rbHabilitado.TabIndex = 86;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = false;
            this.rbHabilitado.CheckedChanged += new System.EventHandler(this.rbHabilitado_CheckedChanged);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.Mantenimiento_Centro_1141515;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 566);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.cmbMuni);
            this.Controls.Add(this.cmbDepar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtMuni);
            this.Controls.Add(this.txtDepar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label lblId;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMuni;
        private System.Windows.Forms.TextBox txtDepar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ComboBox cmbDepar;
        private System.Windows.Forms.ComboBox cmbMuni;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.RadioButton rbHabilitado;
    }
}