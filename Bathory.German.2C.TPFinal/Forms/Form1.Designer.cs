namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnReservar = new Button();
            btnOpciones = new Button();
            lblTitulo = new Label();
            label1 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.Gainsboro;
            btnReservar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservar.Location = new Point(31, 315);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(262, 47);
            btnReservar.TabIndex = 0;
            btnReservar.Text = "Reservar Pasaje";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnOpciones
            // 
            btnOpciones.BackColor = Color.Gainsboro;
            btnOpciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpciones.Location = new Point(425, 315);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(262, 47);
            btnOpciones.TabIndex = 1;
            btnOpciones.Text = "Opciones Administrador";
            btnOpciones.UseVisualStyleBackColor = false;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Courier New", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(166, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(372, 55);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "¡Bienvenido!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 182);
            label1.Name = "label1";
            label1.Size = new Size(568, 37);
            label1.TabIndex = 3;
            label1.Text = "SISTEMA DE RESERVA DE PASAJES\r\n";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gainsboro;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(230, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(262, 47);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            CancelButton = btnSalir;
            ClientSize = new Size(720, 478);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(btnOpciones);
            Controls.Add(btnReservar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva de Pasajes";
            TransparencyKey = SystemColors.ActiveBorder;
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReservar;
        private Button btnOpciones;
        private Label lblTitulo;
        private Label label1;
        private Button btnSalir;
    }
}