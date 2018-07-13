using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba{

    public class ADBrix{

        public void insertarBrix(Entidades.Brix brix){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Brix", brix.Bris));
            cmd.Parameters.Add(new SqlParameter("@Densidad", brix.Densidad));
            cmd.Parameters.Add(new SqlParameter("@Estado", brix.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", brix.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", brix.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", brix.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", brix.Fecha_Modificacion));
            cmd.CommandText = "InsertarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarBrix(Entidades.Brix brix){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Brix", brix.Id_Brix));
            cmd.Parameters.Add(new SqlParameter("@Brix", brix.Bris));
            cmd.Parameters.Add(new SqlParameter("@Densidad", brix.Densidad));
            cmd.Parameters.Add(new SqlParameter("@Estado", brix.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", brix.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", brix.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", brix.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", brix.Fecha_Modificacion));
            cmd.CommandText = "ActualizarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarBrix(int Id_Brix){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Brix", Id_Brix));
            cmd.CommandText = "EliminarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Entidades.Brix> buscarBrix(int Id_Brix){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Brix", Id_Brix));
            cmd.CommandText = "ConsultarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Entidades.Brix> lista = new List<Entidades.Brix>();
            Entidades.Brix brix = new Entidades.Brix();

            while (dr.Read()){

                brix.Id_Brix = Convert.ToInt32(dr["Id_Brix"].ToString());
                brix.Bris = Convert.ToInt32(dr["Brix"].ToString());
                brix.Densidad = Convert.ToDouble(dr["Densidad"].ToString());
                brix.Estado = dr["Estado"].ToString();
                brix.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                brix.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                brix.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                brix.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(brix);
            }
            aux.conectar();
            return lista;
        }

        public List<Brix> listarBrix(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Brix> lista = new List<Brix>();

            while (dr.Read()){

                Brix brix = new Brix();

                brix.Id_Brix = Convert.ToInt32(dr["Id_Brix"].ToString());
                brix.Bris = Convert.ToDouble(dr["Brix"].ToString());
                brix.Densidad = Convert.ToDouble(dr["Densidad"].ToString());
                brix.Estado = dr["Estado"].ToString();
                brix.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                brix.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                brix.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                brix.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(brix);
            }
            aux.conectar();
            return lista;

        }

    }
}
