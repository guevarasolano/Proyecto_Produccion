using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos{

    public class ADProcesoIngresoPiña{

        //MÉTODO PARA INSERTAR PROCESO INGRESO PIÑA:
        public Boolean insertarProcesoIngresoPiña(ProcesoIngresoPiña proceso_Ingreso_Piña){

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
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA ACTUALIZAR PROCESO INGRESO PIÑA:
        public void actualizarProcesoIngresoPiña(ProcesoIngresoPiña proceso_Ingreso_Piña){

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

        //MÉTODO PARA ELIMINAR PROCESO INGRESO PIÑA:
        public Boolean eliminarProcesoIngresoPiña(int Id_Proceso_Ingreso_Piña){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Ingreso_Piña", Id_Proceso_Ingreso_Piña));
            cmd.CommandText = "EliminarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA BUSCAR PROCESO INGRESO PIÑA:
        public ProcesoIngresoPiña buscarProcesoIngresoPiña(int Id_Proceso_Ingreso_Piña){

            ProcesoIngresoPiña proceso_Ingreso_Piña = new ProcesoIngresoPiña();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Ingreso_Piña", Id_Proceso_Ingreso_Piña));
            cmd.CommandText = "ConsultarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();          

            if (dr.Read()){

                proceso_Ingreso_Piña.Id_Proceso_Ingreso_Piña = Convert.ToInt32(dr["Id_Proceso_Ingreso_Piña"].ToString());
                proceso_Ingreso_Piña.Numero_Recibo = Convert.ToInt32(dr["Numero_Recibo"].ToString());
                proceso_Ingreso_Piña.Numero_Carga = dr["Numero_Carga"].ToString();
                proceso_Ingreso_Piña.Cantidad_Piña_Utilizada_Kg = Convert.ToInt32(dr["Cantidad_Piña_Utilizada_Kg"].ToString());
                proceso_Ingreso_Piña.Estado = dr["Estado"].ToString();
                proceso_Ingreso_Piña.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_Ingreso_Piña.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_Ingreso_Piña.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_Ingreso_Piña.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            } else{
                proceso_Ingreso_Piña = null;
            }
            aux.conectar();
            return proceso_Ingreso_Piña;
        }

        //MÉTODO PARA LISTAR PROCESO INGRESO PIÑA:
        public List<ProcesoIngresoPiña> listarProcesoIngresoPiña(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarProcesoIngresoPiña";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<ProcesoIngresoPiña> lista = new List<ProcesoIngresoPiña>();

            while (dr.Read()){

                ProcesoIngresoPiña proceso_Ingreso_Piña = new ProcesoIngresoPiña();

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
