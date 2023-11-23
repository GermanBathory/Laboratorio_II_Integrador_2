using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form4 : Form
    {
        private GestorSqlViaje? gestorSqlViaje;
        private GestorSqlCliente? gestorSqlCliente;

        public Form4()
        {
            InitializeComponent();
            gestorSqlViaje = new GestorSqlViaje();
            gestorSqlCliente = new GestorSqlCliente();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvClientes.DataSource = gestorSqlCliente.ObtenerTodos();
                this.dgvClientes.Columns[1].Visible = false;
                this.dgvPasajes.DataSource = gestorSqlViaje.ObtenerTodos();
                this.dgvPasajes.Columns[5].Visible = false;

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
                this.dgvClientes.DataSource = null;
                this.dgvClientes.DataSource = gestorSqlCliente.ObtenerTodos();
                this.dgvClientes.Columns[1].Visible = false;
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
                this.dgvPasajes.DataSource = null;
                this.dgvPasajes.DataSource = gestorSqlViaje.ObtenerTodos();
                this.dgvPasajes.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.CurrentRow != null)
            {
                try
                {
                    Cliente cliente = (Cliente)this.dgvClientes.CurrentRow.DataBoundItem;

                    if (this.txtNombre.Text != String.Empty && this.txtApellido.Text != String.Empty
                        && this.txtDni.Text != String.Empty && cliente is not null)
                    {
                        Cliente clienteNuevo = new Cliente(this.txtNombre.Text, this.txtApellido.Text,
                             int.Parse(this.txtDni.Text));
                        clienteNuevo.Nombre = this.txtNombre.Text;
                        clienteNuevo.Apellido = this.txtApellido.Text;
                        clienteNuevo.Dni = int.Parse(this.txtDni.Text);
                        gestorSqlCliente.ActualizarPorId(clienteNuevo, cliente.Id_cliente);
                        MessageBox.Show("Cliente modificado.");
                        this.txtNombre.Clear();
                        this.txtApellido.Clear();
                        this.txtDni.Clear();
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
        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.CurrentRow != null)
            {
                try
                {
                    Cliente cliente = (Cliente)this.dgvClientes.CurrentRow.DataBoundItem;

                    if (cliente is not null)
                    {
                        gestorSqlCliente.BorrarPorId(cliente.Id_cliente);
                        MessageBox.Show("Cliente eliminado.");
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
        }

        private void btnBorraPasajes_Click(object sender, EventArgs e)
        {
            if (this.dgvPasajes.CurrentRow != null)
            {
                try
                {
                    Viaje viaje = (Viaje)this.dgvPasajes.CurrentRow.DataBoundItem;

                    if (viaje is not null)
                    {
                        gestorSqlViaje.BorrarPorId(viaje.IdViaje);
                        MessageBox.Show("Pasaje eliminado.");
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
        }

        //private void btnImprimirCliente_Click(object sender, EventArgs e)
        //{
        //}
    }
}
