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
        Cliente? cliente;
        Viaje? viaje;
        List<string> clientes;

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
            }
            for (int i = 0; i < 5; i++)
            {
                string? s = Enum.GetName(typeof(ECiudad), i);
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
            try
            {
                this.AgregarPasaje();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void AgregarPasaje()
        {
            if (this.cmbEmpresa.Text is not null && this.cmbOrigen.SelectedItem is not null &&
                this.cmbDestino.SelectedItem is not null &&
                this.dtpFechaPartida.Text != String.Empty && this.cmbPartida.SelectedItem is not null)
            {
                DateTime fechaPartida = new DateTime();
                DateTime horaPartida = new DateTime();
                fechaPartida = DateTime.Parse(this.dtpFechaPartida.Text);
                horaPartida = DateTime.Parse(this.cmbPartida.Text);

                viaje = new Viaje(Enum.Parse<EEmpresa>(this.cmbEmpresa.Text),
                    Enum.Parse<ECiudad>(this.cmbOrigen.Text), Enum.Parse<ECiudad>(this.cmbDestino.Text),
                    fechaPartida, horaPartida);

                MessageBox.Show($"Viaje cargado.");
                GestorSql.AgregarNuevoViaje(viaje);
            }
            else
            {
                throw new Exception("Algún campo está vacío.");
            }
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cmbDestino.Items.Clear();
            int x = 5;
            this.cmbDestino.Text = "";

            for (int i = 0; i < x; i++)
            {
                string? s = Enum.GetName(typeof(ECiudad), i);
                if (this.cmbOrigen.Text != s)
                {
                    this.cmbDestino.Items.Add(s);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarCliente();


            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

        }

        private void CargarCliente()
        {
            if (this.txtNombre.Text != String.Empty && this.txtApellido.Text != String.Empty &&
                this.txtDni.Text != String.Empty)
            {
                cliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text,
                    int.Parse(this.txtDni.Text));
                cliente.Nombre = this.txtNombre.Text;
                cliente.Apellido = this.txtApellido.Text;
                cliente.Dni = int.Parse(this.txtDni.Text);

                GestorSql.AgregarNuevoCliente(cliente);

            }
            else
            {
                throw new Exception("Algún campo está vacío.");
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.lstClientes.Items.Clear();
            foreach (var item in GestorSql.ObtenerTodosLosClientes())
            {
                this.lstClientes.Items.Add(item.MostrarInformacion());
            }

        }
    }
}
