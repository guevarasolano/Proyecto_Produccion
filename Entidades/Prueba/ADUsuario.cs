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

    public class ADUsuario{

        public void insertarUsuario(Entidades.Usuario usuario){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Dominio", usuario.Dominio));
            cmd.Parameters.Add(new SqlParameter("@Nombre_Usuario", usuario.Nombre_Usuario));
            cmd.Parameters.Add(new SqlParameter("@Nombre_Completo", usuario.Nombre_Completo));
            cmd.Parameters.Add(new SqlParameter("@Primer_Apellido", usuario.Primer_Apellido));
            cmd.Parameters.Add(new SqlParameter("@Segundo_Apellido", usuario.Segundo_Apellido));
            cmd.Parameters.Add(new SqlParameter("@Correo_Electronico", usuario.Correo_Electronico));
            cmd.Parameters.Add(new SqlParameter("@Estado", usuario.Estado));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ultimo_Acceso", usuario.Fecha_Ultimo_Acceso));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", usuario.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", usuario.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", usuario.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", usuario.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", usuario.Fecha_Modificacion));
            cmd.CommandText = "InsertarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarUsuario(Entidades.Usuario usuario){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", usuario.Id_Usuario));
            cmd.Parameters.Add(new SqlParameter("@Dominio", usuario.Dominio));
            cmd.Parameters.Add(new SqlParameter("@Nombre_Usuario", usuario.Nombre_Usuario));
            cmd.Parameters.Add(new SqlParameter("@Nombre_Completo", usuario.Nombre_Completo));
            cmd.Parameters.Add(new SqlParameter("@Primer_Apellido", usuario.Primer_Apellido));
            cmd.Parameters.Add(new SqlParameter("@Segundo_Apellido", usuario.Segundo_Apellido));
            cmd.Parameters.Add(new SqlParameter("@Correo_Electronico", usuario.Correo_Electronico));
            cmd.Parameters.Add(new SqlParameter("@Estado", usuario.Estado));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ultimo_Acceso", usuario.Fecha_Ultimo_Acceso));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", usuario.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", usuario.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", usuario.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", usuario.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", usuario.Fecha_Modificacion));
            cmd.CommandText = "ActualizarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarUsuario(int Id_Usuario){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", Id_Usuario));
            cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Entidades.Usuario> buscarUsuario(int Id_Usuario){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Usuario", Id_Usuario));
            cmd.CommandText = "ConsultarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Entidades.Usuario> lista = new List<Entidades.Usuario>();
            Entidades.Usuario usuario = new Entidades.Usuario();

            while (dr.Read()){

                usuario.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"].ToString());
                usuario.Dominio = dr["Dominio"].ToString();
                usuario.Nombre_Usuario = dr["Nombre_Usuario"].ToString();
                usuario.Nombre_Completo = dr["Nombre_Completo"].ToString();
                usuario.Primer_Apellido = dr["Primer_Apellido"].ToString();
                usuario.Segundo_Apellido = dr["Segundo_Apellido"].ToString();
                usuario.Correo_Electronico = dr["Correo_Electronico"].ToString();
                usuario.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                usuario.Fecha_Ultimo_Acceso = Convert.ToDateTime(dr["Fecha_Ultimo_Acceso"].ToString());
                usuario.Estado_Accion = dr["Estado_Accion"].ToString();
                usuario.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                usuario.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                usuario.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                usuario.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(usuario);
            }
            aux.conectar();
            return lista;
        }

        public List<Usuario> listarUsuario(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();

            while (dr.Read()){

                Usuario usuario = new Usuario();

                usuario.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"].ToString());
                usuario.Dominio = dr["Dominio"].ToString();
                usuario.Nombre_Usuario = dr["Nombre_Usuario"].ToString();
                usuario.Nombre_Completo = dr["Nombre_Completo"].ToString();
                usuario.Primer_Apellido = dr["Primer_Apellido"].ToString();
                usuario.Segundo_Apellido = dr["Segundo_Apellido"].ToString();
                usuario.Correo_Electronico = dr["Correo_Electronico"].ToString();
                usuario.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                usuario.Fecha_Ultimo_Acceso = Convert.ToDateTime(dr["Fecha_Ultimo_Acceso"].ToString());
                usuario.Estado_Accion = dr["Estado_Accion"].ToString();
                usuario.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                usuario.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                usuario.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                usuario.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(usuario);
            }
            aux.conectar();
            return lista;

        }

    }
}
