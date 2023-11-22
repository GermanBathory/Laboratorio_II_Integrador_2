using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((this.txtUsuario.Text == "admin" || this.txtUsuario.Text == "ADMIN") &&
                this.txtContrasena.Text == "admin" || this.txtContrasena.Text == "ADMIN")
            {
                MessageBox.Show("Logueo correcto!");
                this.txtUsuario.Clear();
                this.txtContrasena.Clear();
                Form4 administrar = new Form4();
                administrar.ShowDialog();

                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                this.txtUsuario.Clear();
                this.txtContrasena.Clear();
            }
        }
    }
}
