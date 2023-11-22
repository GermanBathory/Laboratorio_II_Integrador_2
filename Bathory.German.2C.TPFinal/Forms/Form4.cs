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
    public partial class Form4 : Form
    {
        int id = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in GestorSql.ObtenerTodosLosClientes())
                {
                    this.lstClientes.Items.Add(item.MostrarInformacion());
                }

                foreach (var item in GestorSql.ObtenerTodosLosViajes())
                {
                    this.lstPasajes.Items.Add(item.ImprimirPasaje());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstClientes.Items.Clear();
                foreach (var item in GestorSql.ObtenerTodosLosClientes())
                {
                    this.lstClientes.Items.Add(item.MostrarInformacion());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMostrarPasajes_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstPasajes.Items.Clear();
                foreach (var item in GestorSql.ObtenerTodosLosViajes())
                {
                    this.lstPasajes.Items.Add(item.ImprimirPasaje());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            try
            {

                Cliente cliente;
                id = lstClientes.SelectedIndex + 1;

                if (this.txtNombre.Text != String.Empty && this.txtApellido.Text != String.Empty
                    && this.txtDni.Text != String.Empty && id >= 0)
                {
                    cliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text,
                        int.Parse(this.txtDni.Text));
                    cliente.Nombre = this.txtNombre.Text;
                    cliente.Apellido = this.txtApellido.Text;
                    cliente.Dni = int.Parse(this.txtDni.Text);
                    GestorSql.ActualizarClientePorId(cliente, id);
                    MessageBox.Show("Cliente modificado.");
                }
                else
                {
                    throw new Exception("Algún campo está vacio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            id = this.lstClientes.SelectedIndex + 1;

            GestorSql.BorrarUnClientePorId(id);
            this.lstClientes.Items.RemoveAt(id);
            MessageBox.Show("Cliente eliminado.");



        }

        private void btnBorraPasajes_Click(object sender, EventArgs e)
        {
            int id;
            id = this.lstPasajes.SelectedIndex + 1;

            GestorSql.BorrarUnViajePorId(id);
            this.lstPasajes.Items.Add("");
            MessageBox.Show("Pasaje eliminado.");

        }
    }
}
