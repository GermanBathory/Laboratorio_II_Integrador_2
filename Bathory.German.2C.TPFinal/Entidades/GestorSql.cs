using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades
{
    public static class GestorSql
    {
        private static string stringConnection;

        static GestorSql()
        {
            GestorSql.stringConnection =
                "Server=.;Database=Mi_Bdd;Trusted_Connection=True;";
        }

        public static List<Cliente> ObtenerTodosLosClientes()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
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

        public static Cliente ObtenerClientePorId(int id)
        {
            List<Cliente> clientes = GestorSql.ObtenerTodosLosClientes();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id_cliente == id)
                {
                    return cliente;
                }
            }
            throw new ElementoNoEncontradoException("Ningun elemento para ese ID");
        }

        public static int AgregarNuevoCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.stringConnection))
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

        public static bool BorrarUnClientePorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.stringConnection))
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

        public static bool ActualizarClientePorId(Cliente cliente, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.stringConnection))
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

        public static List<Viaje> ObtenerTodosLosViajes()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
                {
                    List<Viaje> viajes = new List<Viaje>();
                    string query = "SELECT * FROM viajes";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Viaje viaje = new Viaje();
                            viaje.IdViaje = reader.GetInt32(0);
                            viaje.Empresa = Enum.Parse<EEmpresa>(reader.GetString(1));
                            viaje.Origen = Enum.Parse<ECiudad>(reader.GetString(2));
                            viaje.Destino = Enum.Parse<ECiudad>(reader.GetString(3));
                            viaje.FechaPartida = DateTime.Parse (reader.GetString(4));
                            viaje.HoraPartida = DateTime.Parse (reader.GetString(5));

                            viajes.Add(viaje);
                        }
                        return viajes;
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

        public static int AgregarNuevoViaje(Viaje viaje)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.stringConnection))
                {
                    string query = "INSERT INTO viajes (empresa,origen,destino,fecha,hora)" +
                        "values (@empresa,@origen,@destino,@fecha,@hora); SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("empresa", viaje.Empresa.ToString());
                    command.Parameters.AddWithValue("origen", viaje.Origen.ToString());
                    command.Parameters.AddWithValue("destino", viaje.Destino.ToString());
                    command.Parameters.AddWithValue("fecha", viaje.FechaPartida.ToString("dd/MM/yyyy"));
                    command.Parameters.AddWithValue("hora", viaje.HoraPartida.ToString("HH:mm"));
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return (int)reader.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al agregar un nuevo viaje", ex);
            }
        }

        public static bool BorrarUnViajePorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.stringConnection))
                {
                    string query = "DELETE FROM viajes WHERE id_pasaje=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al borrar un pasaje", ex);
            }
        }

    }
}
