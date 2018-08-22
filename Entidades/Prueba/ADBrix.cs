using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos { 

public class ADBrix{

        //MÉTODO PARA INSERTAR BRIX:
        public Boolean insertarBrix(Brix brix){

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
            int x= cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA ACTUALIZAR BRIX:
        public void actualizarBrix(Brix brix){

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

        //MÉTODO PARA ELIMINAR BRIX:
        public Boolean eliminarBrix(int Id_Brix){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Brix", Id_Brix));
            cmd.CommandText = "EliminarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            int x= cmd.ExecuteNonQuery();
            aux.conectar();
            if(x >= 1){
                return true;
            }else{
                return false;
                }
            }

        //MÉTODO PARA BUSCAR BRIX:
        public Brix buscarBrix(int Id_Brix){

            Brix brix = new Brix();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Brix", Id_Brix));
            cmd.CommandText = "ConsultarBrix";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                brix.Id_Brix = Convert.ToInt32(dr["Id_Brix"].ToString());
                brix.Bris = Convert.ToInt32(dr["Brix"].ToString());
                brix.Densidad = Convert.ToDouble(dr["Densidad"].ToString());
                brix.Estado = dr["Estado"].ToString();
                brix.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                brix.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                brix.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                brix.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            } else{
                brix = null;
            }
                aux.conectar();
                return brix;
            }

        //MÉTODO PARA LISTAR BRIX:
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
