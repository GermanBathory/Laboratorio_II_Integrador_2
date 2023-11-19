using Entidades;
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
    public partial class Form2 : Form
    {
        Cliente cliente;
        Viaje viaje;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.dtpFechaPartida.MinDate = DateTime.Now.AddDays(1);
            DateTime salida = new DateTime();

            for (int i = 0; i < 5; i++)
            {
                string? s = Enum.GetName(typeof(EEmpresa), i);
                this.cmbEmpresa.Items.Add(s);
            }

            for (int i = 0; i < 5; i++)
            {
                string? s = Enum.GetName(typeof(ECiudad), i);
                this.cmbOrigen.Items.Add(s);
                this.cmbDestino.Items.Add(s);
            }

            for (int i = 0; i < 48; i++)
            {
                this.cmbPartida.Items.Add(salida.ToString("HH:mm"));
                salida = salida.AddHours(1);
            }


        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //try { cliente.Nombre = txtNombre.Text; }
            //catch { }

        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la seccion de Reserva?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            viaje = new Viaje((EEmpresa)this.cmbEmpresa.SelectedItem, (ECiudad)this.cmbOrigen.SelectedItem,
                (ECiudad)this.cmbDestino.SelectedItem, (DateTime)this.dtpFechaPartida.Value, 
                (DateTime)this.cmbPartida.SelectedItem);
            MessageBox.Show($"{viaje.ImprimirPasaje}");


        }
    }
}
