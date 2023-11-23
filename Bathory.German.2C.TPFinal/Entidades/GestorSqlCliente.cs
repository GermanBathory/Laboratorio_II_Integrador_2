using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades
{
    public class GestorSqlCliente : IManejoBaseDeDatos<Cliente>
    {
        private ConexionSql _conexion;
        public GestorSqlCliente()
        {
            _conexion = new ConexionSql();
        }

        public List<Cliente> ObtenerTodos()
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
                {
                    List<Cliente> clientes = new List<Cliente>();
                    string query = "SELECT * FROM clientes";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.Id_cliente = reader.GetInt32(0);
                            cliente.Nombre = reader.GetString(1);
                            cliente.Apellido = reader.GetString(2);
                            cliente.Dni = reader.GetInt32(3);
                            clientes.Add(cliente);
                        }
                        return clientes;
                    }
                    else
                    {
                        throw new ElementoNoEncontradoException("Tabla vacia");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al obtener elemento", ex);
            }
        }

        public Cliente ObtenerPorId(int id)
        {
            List<Cliente> clientes = this.ObtenerTodos();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id_cliente == id)
                {
                    return cliente;
                }
            }
            throw new ElementoNoEncontradoException("Ningun elemento para ese ID");
        }

        public int AgregarNuevo(Cliente cliente)
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
                {
                    string query = "INSERT INTO clientes (nombre,apellido,dni)" +
                        "values (@nombre,@apellido,@dni); SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("dni", cliente.Dni);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return (int)reader.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al agregar un nuevo cliente", ex);
            }
        }

        public bool BorrarPorId(int id)
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
                {
                    string query = "DELETE FROM clientes WHERE id_clientes=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al borrar un cliente", ex);
            }
        }

        public bool ActualizarPorId(Cliente cliente, int id)
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
                {
                    string query = "UPDATE clientes set nombre=@nombre, apellido=@apellido, " +
                        "dni=@dni WHERE id_clientes=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("dni", cliente.Dni);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al actualizar cliente", ex);
            }
        }
    }
}
