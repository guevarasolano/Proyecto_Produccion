using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Models { 

    public class ADAplicacion{
        
        //MÉTODO PARA INSERTAR APLICACIÓN:
        public Boolean insertarAplicacion(Aplicacion aplicacion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Codigo", aplicacion.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", aplicacion.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Controlador", aplicacion.Controlador));
            cmd.Parameters.Add(new SqlParameter("@Estado", aplicacion.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", aplicacion.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", aplicacion.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", aplicacion.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", aplicacion.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", aplicacion.Fecha_Modificacion));
            cmd.CommandText = "InsertarAplicacion";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }
            else{
                return false;
            }
        }

        //MÉTODO PARA ACTUALIZAR APLICACIÓN:
        public void actualizarAplicacion(Aplicacion aplicacion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Aplicacion", aplicacion.Id_Aplicacion));
            cmd.Parameters.Add(new SqlParameter("@Codigo", aplicacion.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", aplicacion.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Controlador", aplicacion.Controlador));
            cmd.Parameters.Add(new SqlParameter("@Estado", aplicacion.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", aplicacion.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", aplicacion.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", aplicacion.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", aplicacion.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", aplicacion.Fecha_Modificacion));
            cmd.CommandText = "ActualizarAplicacion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        //MÉTODO PARA ELIMINAR APLICACIÓN:
        public Boolean eliminarAplicacion(int Id_Aplicacion){
            
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Aplicacion", Id_Aplicacion));
            cmd.CommandText = "EliminarAplicacion";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA BUSCAR APLICACIÓN:
        public Aplicacion buscarAplicacion(int Id_Aplicacion){

            Aplicacion aplicacion = new Aplicacion();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Aplicacion", Id_Aplicacion));
            cmd.CommandText = "ConsultarAplicacion";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                aplicacion.Id_Aplicacion = Convert.ToInt32(dr["Id_Aplicacion"].ToString());
                aplicacion.Codigo = dr["Codigo"].ToString();
                aplicacion.Descripcion = dr["Descripcion"].ToString();
                aplicacion.Controlador = dr["Controlador"].ToString();
                aplicacion.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                aplicacion.Estado_Accion = dr["Estado_Accion"].ToString();
                aplicacion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                aplicacion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                aplicacion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                aplicacion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

        } else{
            aplicacion = null;
        }
        aux.conectar();
        return aplicacion;
    }

        //MÉTODO PARA LISTAR APLICACIÓN:
        public List<Aplicacion> listarAplicacion(){

                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.CommandText = "ListarAplicacion";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<Aplicacion> lista = new List<Aplicacion>();

                while (dr.Read()){

                Aplicacion aplicacion = new Aplicacion();

                aplicacion.Id_Aplicacion = Convert.ToInt32(dr["Id_Aplicacion"].ToString());
                aplicacion.Codigo = dr["Codigo"].ToString();
                aplicacion.Descripcion = dr["Descripcion"].ToString();
                aplicacion.Controlador = dr["Controlador"].ToString();
                aplicacion.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                aplicacion.Estado_Accion = dr["Estado_Accion"].ToString();
                aplicacion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                aplicacion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                aplicacion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                aplicacion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(aplicacion);
            }
            aux.conectar();
            return lista;
        }
}

}

