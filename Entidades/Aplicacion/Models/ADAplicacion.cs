using AccesoDatos;
using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ADAplicacion{

        public Boolean insertarAplicacion(Aplicacion.Models.Aplicacion aplicacion){

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

        public void actualizarAplicacion(Aplicacion.Models.Aplicacion aplicacion){

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
            }
            else{
                return false;
            }
        }
        
        public Aplicacion.Models.Aplicacion buscarAplicacion(int Id_Aplicacion){

            Aplicacion.Models.Aplicacion aplicacion = new Aplicacion.Models.Aplicacion();
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

    public List<Aplicacion.Models.Aplicacion> listarAplicacion(){

                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.CommandText = "ListarAplicacion";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<Aplicacion.Models.Aplicacion> lista = new List<Aplicacion.Models.Aplicacion>();

                while (dr.Read()){

                Aplicacion.Models.Aplicacion aplicacion = new Aplicacion.Models.Aplicacion();

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

