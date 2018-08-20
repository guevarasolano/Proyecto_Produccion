using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rol.Models{

    public class ADRol{

        //MÉTODO PARA INSERTAR ROL:
        public Boolean insertarRol(Rol rol){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Codigo", rol.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", rol.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Estado", rol.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", rol.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", rol.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", rol.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", rol.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", rol.Fecha_Modificacion));
            cmd.CommandText = "InsertarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA ACTUALIZAR ROL:
        public void actualizarRol(Rol rol){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Rol", rol.Id_Rol));
            cmd.Parameters.Add(new SqlParameter("@Codigo", rol.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", rol.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Estado", rol.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", rol.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", rol.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", rol.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", rol.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", rol.Fecha_Modificacion));
            cmd.CommandText = "ActualizarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        //MÉTODO PARA ELIMINAR ROL:
        public Boolean eliminarRol(int Id_Rol){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Rol", Id_Rol));
            cmd.CommandText = "EliminarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA BUSCAR ROL:
        public Rol buscarRol(int Id_Rol){

            Rol rol = new Rol();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Rol", Id_Rol));
            cmd.CommandText = "ConsultarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();            

            if (dr.Read()){

                rol.Id_Rol = Convert.ToInt32(dr["Id_Rol"].ToString());
                rol.Codigo = dr["Codigo"].ToString();
                rol.Descripcion = dr["Descripcion"].ToString();
                rol.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                rol.Estado_Accion = dr["Estado_Accion"].ToString();
                rol.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                rol.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                rol.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                rol.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                rol = null;
            }

            aux.conectar();
            return rol;
        }

        //MÉTODO PARA LISTAR ROL:
        public List<Rol> listarRol(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Rol> lista = new List<Rol>();

            while (dr.Read()){

                Rol rol = new Rol();

                rol.Id_Rol = Convert.ToInt32(dr["Id_Rol"].ToString());
                rol.Codigo = dr["Codigo"].ToString();
                rol.Descripcion = dr["Descripcion"].ToString();
                rol.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                rol.Estado_Accion = dr["Estado_Accion"].ToString();
                rol.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                rol.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                rol.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                rol.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(rol);
            }
            aux.conectar();
            return lista;

        }

    }
}
