namespace Forms
{
    partial class Form3
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
            lblIngreso = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreso.Location = new Point(21, 47);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(349, 25);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "INGRESE DATOS DE ADMINISTRADOR";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblUsuario.Location = new Point(21, 139);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(58, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblContrasena.Location = new Point(21, 255);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(82, 20);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(21, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(222, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(21, 278);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(222, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(21, 376);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 33);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(248, 376);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(185, 33);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(455, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblIngreso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private Button btnSalir;
    }
}