namespace Forms
{
    partial class Form4
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
            btnMostrarClientes = new Button();
            btnModificarClientes = new Button();
            btnBorrarClientes = new Button();
            btnMostrarPasajes = new Button();
            btnBorraPasajes = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            dgvClientes = new DataGridView();
            dgvPasajes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasajes).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(486, 53);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(204, 29);
            btnMostrarClientes.TabIndex = 2;
            btnMostrarClientes.Text = "Actualizar Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // btnModificarClientes
            // 
            btnModificarClientes.Location = new Point(525, 158);
            btnModificarClientes.Name = "btnModificarClientes";
            btnModificarClientes.Size = new Size(204, 29);
            btnModificarClientes.TabIndex = 3;
            btnModificarClientes.Text = "Modificar Cliente";
            btnModificarClientes.UseVisualStyleBackColor = true;
            btnModificarClientes.Click += btnModificarClientes_Click;
            // 
            // btnBorrarClientes
            // 
            btnBorrarClientes.Location = new Point(486, 88);
            btnBorrarClientes.Name = "btnBorrarClientes";
            btnBorrarClientes.Size = new Size(204, 29);
            btnBorrarClientes.TabIndex = 4;
            btnBorrarClientes.Text = "Borrar Cliente";
            btnBorrarClientes.UseVisualStyleBackColor = true;
            btnBorrarClientes.Click += btnBorrarClientes_Click;
            // 
            // btnMostrarPasajes
            // 
            btnMostrarPasajes.Location = new Point(49, 528);
            btnMostrarPasajes.Name = "btnMostrarPasajes";
            btnMostrarPasajes.Size = new Size(204, 29);
            btnMostrarPasajes.TabIndex = 5;
            btnMostrarPasajes.Text = "Actualizar Pasajes";
            btnMostrarPasajes.UseVisualStyleBackColor = true;
            btnMostrarPasajes.Click += btnMostrarPasajes_Click;
            // 
            // btnBorraPasajes
            // 
            btnBorraPasajes.Location = new Point(347, 528);
            btnBorraPasajes.Name = "btnBorraPasajes";
            btnBorraPasajes.Size = new Size(204, 29);
            btnBorraPasajes.TabIndex = 7;
            btnBorraPasajes.Text = "Borrar Pasaje";
            btnBorraPasajes.UseVisualStyleBackColor = true;
            btnBorraPasajes.Click += btnBorraPasajes_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(445, 220);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(682, 220);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(106, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(573, 250);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(106, 23);
            txtDni.TabIndex = 10;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(445, 202);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 15);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nuevo Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(682, 202);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Nuevo Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(593, 232);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(65, 15);
            lblDni.TabIndex = 13;
            lblDni.Text = "Nuevo DNI";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 21);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(416, 224);
            dgvClientes.TabIndex = 14;
            // 
            // dgvPasajes
            // 
            dgvPasajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajes.Location = new Point(12, 317);
            dgvPasajes.Name = "dgvPasajes";
            dgvPasajes.ReadOnly = true;
            dgvPasajes.RowTemplate.Height = 25;
            dgvPasajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasajes.Size = new Size(566, 180);
            dgvPasajes.TabIndex = 15;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(dgvPasajes);
            Controls.Add(dgvClientes);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnBorraPasajes);
            Controls.Add(btnMostrarPasajes);
            Controls.Add(btnBorrarClientes);
            Controls.Add(btnModificarClientes);
            Controls.Add(btnMostrarClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form4";
            Text = "Opciones de Administrador";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMostrarClientes;
        private Button btnModificarClientes;
        private Button btnBorrarClientes;
        private Button btnMostrarPasajes;
        private Button btnBorraPasajes;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private DataGridView dgvClientes;
        private DataGridView dgvPasajes;
    }
}