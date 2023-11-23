using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Entidades
{
    internal class ConexionSql
    {
        private string _stringConnection;

        public ConexionSql()
        {
            this._stringConnection = "Server=.;Database=Mi_Bdd;Trusted_Connection=True;";
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection conexion = new SqlConnection(_stringConnection);
            return conexion;
        }
    }
}
