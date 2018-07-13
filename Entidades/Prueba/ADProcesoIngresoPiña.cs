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

    public class ADProcesoIngresoPiña{

        public void insertarProcesoIngresoPiña(Proceso_Ingreso_Piña proceso_Ingreso_Piña){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Numero_Recibo", proceso_Ingreso_Piña.Numero_Recibo));
            cmd.Parameters.Add(new SqlParameter("@Numero_Carga", proceso_Ingreso_Piña.Numero_Carga));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Piña_Utilizada_Kg", proceso_Ingreso_Piña.Cantidad_Piña_Utilizada_Kg));
            cmd.Parameters.Add(new SqlParameter("@Estado", proceso_Ingreso_Piña.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_Ingreso_Piña.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_Ingreso_Piña.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_Ingreso_Piña.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_Ingreso_Piña.Fecha_Modificacion));
            cmd.CommandText = "InsertarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarProcesoIngresoPiña(Proceso_Ingreso_Piña proceso_Ingreso_Piña){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Ingreso_Piña", proceso_Ingreso_Piña.Id_Proceso_Ingreso_Piña));
            cmd.Parameters.Add(new SqlParameter("@Numero_Recibo", proceso_Ingreso_Piña.Numero_Recibo));
            cmd.Parameters.Add(new SqlParameter("@Numero_Carga", proceso_Ingreso_Piña.Numero_Carga));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Piña_Utilizada_Kg", proceso_Ingreso_Piña.Cantidad_Piña_Utilizada_Kg));
            cmd.Parameters.Add(new SqlParameter("@Estado", proceso_Ingreso_Piña.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_Ingreso_Piña.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_Ingreso_Piña.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_Ingreso_Piña.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_Ingreso_Piña.Fecha_Modificacion));
            cmd.CommandText = "ActualizarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarProcesoIngresoPiña(int Id_Proceso_Ingreso_Piña){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Ingreso_Piña", Id_Proceso_Ingreso_Piña));
            cmd.CommandText = "EliminarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Proceso_Ingreso_Piña> buscarProcesoIngresoPiña(int Id_Proceso_Ingreso_Piña){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Ingreso_Piña", Id_Proceso_Ingreso_Piña));
            cmd.CommandText = "ConsultarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Proceso_Ingreso_Piña> lista = new List<Proceso_Ingreso_Piña>();
            Proceso_Ingreso_Piña proceso_Ingreso_Piña = new Proceso_Ingreso_Piña();

            while (dr.Read()){

                proceso_Ingreso_Piña.Id_Proceso_Ingreso_Piña = Convert.ToInt32(dr["Id_Proceso_Ingreso_Piña"].ToString());
                proceso_Ingreso_Piña.Numero_Recibo = Convert.ToInt32(dr["Numero_Recibo"].ToString());
                proceso_Ingreso_Piña.Numero_Carga = dr["Numero_Carga"].ToString();
                proceso_Ingreso_Piña.Cantidad_Piña_Utilizada_Kg = Convert.ToInt32(dr["Cantidad_Piña_Utilizada_Kg"].ToString());
                proceso_Ingreso_Piña.Estado = dr["Estado"].ToString();
                proceso_Ingreso_Piña.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_Ingreso_Piña.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_Ingreso_Piña.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_Ingreso_Piña.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(proceso_Ingreso_Piña);
            }
            aux.conectar();
            return lista;
        }

        public List<Proceso_Ingreso_Piña> listarProcesoIngresoPiña(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Proceso_Ingreso_Piña> lista = new List<Proceso_Ingreso_Piña>();

            while (dr.Read()){

                Proceso_Ingreso_Piña proceso_Ingreso_Piña = new Proceso_Ingreso_Piña();

                proceso_Ingreso_Piña.Id_Proceso_Ingreso_Piña = Convert.ToInt32(dr["Id_Proceso_Ingreso_Piña"].ToString());
                proceso_Ingreso_Piña.Numero_Recibo = Convert.ToInt32(dr["Numero_Recibo"].ToString());
                proceso_Ingreso_Piña.Numero_Carga = dr["Numero_Carga"].ToString();
                proceso_Ingreso_Piña.Cantidad_Piña_Utilizada_Kg = Convert.ToInt32(dr["Cantidad_Piña_Utilizada_Kg"].ToString());
                proceso_Ingreso_Piña.Estado = dr["Estado"].ToString();
                proceso_Ingreso_Piña.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_Ingreso_Piña.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_Ingreso_Piña.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_Ingreso_Piña.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(proceso_Ingreso_Piña);
            }
            aux.conectar();
            return lista;

        }

    }
}
