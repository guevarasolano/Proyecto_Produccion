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

    public class ADRol{

        public void insertarRol(Entidades.Rol rol){

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
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarRol(Entidades.Rol rol){

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

        public void eliminarRol(int Id_Rol){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Rol", Id_Rol));
            cmd.CommandText = "EliminarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Entidades.Rol> buscarRol(int Id_Rol){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Rol", Id_Rol));
            cmd.CommandText = "ConsultarRol";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Entidades.Rol> lista = new List<Entidades.Rol>();
            Entidades.Rol rol = new Entidades.Rol();

            while (dr.Read()){

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
