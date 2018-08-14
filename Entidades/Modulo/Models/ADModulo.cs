using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Modulo.Models{

    public class ADModulo{

        public Boolean insertarModulo(Modulo modulo){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Aplicacion", modulo.FK_Id_Aplicacion));
            cmd.Parameters.Add(new SqlParameter("@Codigo", modulo.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", modulo.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Controlador", modulo.Controlador));
            cmd.Parameters.Add(new SqlParameter("@Estado", modulo.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", modulo.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", modulo.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", modulo.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", modulo.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", modulo.Fecha_Modificacion));
            cmd.CommandText = "InsertarModulo";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        public void actualizarModulo(Modulo modulo){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Modulo", modulo.Id_Modulo));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Aplicacion", modulo.FK_Id_Aplicacion));
            cmd.Parameters.Add(new SqlParameter("@Codigo", modulo.Codigo));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", modulo.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Controlador", modulo.Controlador));
            cmd.Parameters.Add(new SqlParameter("@Estado", modulo.Estado));
            cmd.Parameters.Add(new SqlParameter("@Estado_Accion", modulo.Estado_Accion));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", modulo.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", modulo.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", modulo.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", modulo.Fecha_Modificacion));
            cmd.CommandText = "ActualizarModulo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public bool eliminarModulo(int Id_Modulo){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Modulo", Id_Modulo));
            cmd.CommandText = "EliminarModulo";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        public Modulo buscarModulo(int Id_Modulo){

            Modulo modulo = new Modulo();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Modulo", Id_Modulo));
            cmd.CommandText = "ConsultarModulo";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                modulo.Id_Modulo = Convert.ToInt32(dr["Id_Modulo"].ToString());
                modulo.FK_Id_Aplicacion = Convert.ToInt32(dr["FK_Id_Aplicacion"].ToString());
                modulo.Codigo = dr["Codigo"].ToString();
                modulo.Descripcion = dr["Descripcion"].ToString();
                modulo.Controlador = dr["Controlador"].ToString();
                modulo.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                modulo.Estado_Accion = dr["Estado_Accion"].ToString();
                modulo.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                modulo.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                modulo.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                modulo.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                modulo = null;
            }
            aux.conectar();
            return modulo;
        }

        public List<Modulo> listarModulo(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarModulo";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modulo> lista = new List<Modulo>();

            while (dr.Read()){

                Modulo modulo = new Modulo();

                modulo.Id_Modulo = Convert.ToInt32(dr["Id_Modulo"].ToString());
                modulo.FK_Id_Aplicacion = Convert.ToInt32(dr["FK_Id_Aplicacion"].ToString());
                modulo.Codigo = dr["Codigo"].ToString();
                modulo.Descripcion = dr["Descripcion"].ToString();
                modulo.Controlador = dr["Controlador"].ToString();
                modulo.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                modulo.Estado_Accion = dr["Estado_Accion"].ToString();
                modulo.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                modulo.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                modulo.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                modulo.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(modulo);
            }
            aux.conectar();
            return lista;
        }

    }
}