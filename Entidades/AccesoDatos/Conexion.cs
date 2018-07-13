using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace AccesoDatos{

    public class Conexion{


        public SqlConnection Conectar() { 
        string strConn = "Data Source=SRV-DB01;Initial Catalog=Sistema_Produccion_Pruebas;Integrated Security=True";
        SqlConnection conn = new SqlConnection(strConn);

            try
            {
                if (conn.State.Equals(ConnectionState.Closed)) conn.Open();
                else conn.Closed();
            }

            catch(Exception ex)
            {

            }

            return conn;
        }

    }
}
