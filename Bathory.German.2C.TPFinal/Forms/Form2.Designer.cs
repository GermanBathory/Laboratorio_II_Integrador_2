﻿namespace Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblNuevoCliente = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            btnGuardar = new Button();
            lblDatos = new Label();
            cmbEmpresa = new ComboBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            cmbPartida = new ComboBox();
            lblEmpresa = new Label();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblPartida = new Label();
            dtpFechaPartida = new DateTimePicker();
            lblFecha = new Label();
            btnReservar = new Button();
            btnCancelar = new Button();
            btnClientes = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNuevoCliente
            // 
            lblNuevoCliente.AutoSize = true;
            lblNuevoCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNuevoCliente.Location = new Point(12, 18);
            lblNuevoCliente.Name = "lblNuevoCliente";
            lblNuevoCliente.Size = new Size(157, 20);
            lblNuevoCliente.TabIndex = 0;
            lblNuevoCliente.Text = "Ingresar nuevo cliente:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre\r\n";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(11, 127);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(12, 187);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(11, 151);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(11, 211);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(156, 23);
            txtDni.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(252, 151);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 27);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Cliente";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos.Location = new Point(12, 270);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(123, 20);
            lblDatos.TabIndex = 11;
            lblDatos.Text = "Datos del pasaje:";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(12, 332);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(133, 23);
            cmbEmpresa.TabIndex = 12;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(185, 332);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(133, 23);
            cmbOrigen.TabIndex = 13;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            cmbOrigen.SelectedValueChanged += cmbOrigen_SelectedValueChanged;
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(349, 332);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(133, 23);
            cmbDestino.TabIndex = 14;
            // 
            // cmbPartida
            // 
            cmbPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(276, 393);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(133, 23);
            cmbPartida.TabIndex = 16;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(12, 309);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(66, 20);
            lblEmpresa.TabIndex = 17;
            lblEmpresa.Text = "Empresa\r\n";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrigen.Location = new Point(185, 309);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 20);
            lblOrigen.TabIndex = 18;
            lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestino.Location = new Point(349, 309);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(60, 20);
            lblDestino.TabIndex = 19;
            lblDestino.Text = "Destino";
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPartida.Location = new Point(276, 370);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(113, 20);
            lblPartida.TabIndex = 20;
            lblPartida.Text = "Hora de Partida";
            // 
            // dtpFechaPartida
            // 
            dtpFechaPartida.Location = new Point(12, 393);
            dtpFechaPartida.Name = "dtpFechaPartida";
            dtpFechaPartida.Size = new Size(227, 23);
            dtpFechaPartida.TabIndex = 21;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(12, 370);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(118, 20);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "Fecha de Partida";
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(510, 393);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(107, 27);
            btnReservar.TabIndex = 23;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(644, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 27);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cerrar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(282, 60);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(107, 27);
            btnClientes.TabIndex = 26;
            btnClientes.Text = "Mostrar Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(412, 39);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(376, 251);
            dgvClientes.TabIndex = 27;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(btnClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnReservar);
            Controls.Add(lblFecha);
            Controls.Add(dtpFechaPartida);
            Controls.Add(lblPartida);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(lblEmpresa);
            Controls.Add(cmbPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(cmbEmpresa);
            Controls.Add(lblDatos);
            Controls.Add(btnGuardar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblNuevoCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            Text = "Reservar Pasaje";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevoCliente;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Button btnGuardar;
        private Label lblDatos;
        private ComboBox cmbEmpresa;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private ComboBox cmbArribo;
        private ComboBox cmbPartida;
        private Label lblEmpresa;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblPartida;
        private DateTimePicker dtpFechaPartida;
        private Label lblFecha;
        private Label lblArribo;
        private Button btnReservar;
        private Button btnCancelar;
        private Button btnClientes;
        private DataGridView dgvClientes;
    }
}