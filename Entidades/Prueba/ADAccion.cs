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

    public class ADAccion{

        public void insertarAccion(Entidades.Accion accion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Modulo", accion.FK_Id_Modulo));
            cmd.Parameters.Add(new SqlParameter("@Codigo", accion.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", accion.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Estado", accion.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", accion.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", accion.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", accion.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", accion.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", accion.Fecha_Modificacion));
            cmd.CommandText = "InsertarAccion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarAccion(Entidades.Accion accion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Accion", accion.Id_Accion));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Modulo", accion.FK_Id_Modulo));
            cmd.Parameters.Add(new SqlParameter("@Codigo", accion.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", accion.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Estado", accion.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", accion.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", accion.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", accion.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", accion.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", accion.Fecha_Modificacion));
            cmd.CommandText = "ActualizarAccion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarAccion(int Id_Accion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Accion", Id_Accion));
            cmd.CommandText = "EliminarAccion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Entidades.Accion> buscarAccion(int Id_Accion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Accion", Id_Accion));
            cmd.CommandText = "ConsultarAccion";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Entidades.Accion> lista = new List<Entidades.Accion>();
            Entidades.Accion accion = new Entidades.Accion();

            while (dr.Read()){

                accion.Id_Accion = Convert.ToInt32(dr["Id_Accion"].ToString());
                accion.FK_Id_Modulo = Convert.ToInt32(dr["FK_Id_Modulo"].ToString());
                accion.Codigo = dr["Codigo"].ToString();
                accion.Descripcion = dr["Descripcion"].ToString();
                accion.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                accion.Estado_Accion = dr["Estado_Accion"].ToString();
                accion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                accion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                accion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                accion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(accion);
            }
            aux.conectar();
            return lista;
        }

        public List<Accion> listarAccion(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarAccion";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Accion> lista = new List<Accion>();

            while (dr.Read()){

                Accion accion = new Accion();

                accion.Id_Accion = Convert.ToInt32(dr["Id_Accion"].ToString());
                accion.FK_Id_Modulo = Convert.ToInt32(dr["FK_Id_Modulo"].ToString());
                accion.Codigo = dr["Codigo"].ToString();
                accion.Descripcion = dr["Descripcion"].ToString();
                accion.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                accion.Estado_Accion = dr["Estado_Accion"].ToString();
                accion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                accion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                accion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                accion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(accion);
            }
            aux.conectar();
            return lista;

        }

    }
}
