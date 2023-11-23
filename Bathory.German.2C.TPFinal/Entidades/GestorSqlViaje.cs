using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades
{
    public class GestorSqlViaje: IManejoBaseDeDatos<Viaje>
    {
        private ConexionSql _conexion;

        public GestorSqlViaje()
        {
            _conexion = new ConexionSql();
        }

        public List<Viaje> ObtenerTodos()
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
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
                            viaje.FechaPartida = DateTime.Parse(reader.GetString(4));
                            viaje.HoraPartida = DateTime.Parse(reader.GetString(5));

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

        public Viaje ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int AgregarNuevo(Viaje viaje)
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
                {
                    string query = "INSERT INTO viajes (empresa,origen,destino,fecha,hora)" +
                        "values (@empresa,@origen,@destino,@fecha,@hora); SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("empresa", viaje.Empresa.ToString());
                    command.Parameters.AddWithValue("origen", viaje.Origen.ToString());
                    command.Parameters.AddWithValue("destino", viaje.Destino.ToString());
                    command.Parameters.AddWithValue("fecha", viaje.FechaPartida.FormatoFechaPropio());
                    command.Parameters.AddWithValue("hora", viaje.HoraPartida.FormatoHoraPropio());
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

        public bool BorrarPorId(int id)
        {
            try
            {
                using SqlConnection connection = _conexion.CrearConexion();
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

        public bool ActualizarPorId(Cliente cliente, int id)
        {
            throw new NotImplementedException();
        }
    }
}
