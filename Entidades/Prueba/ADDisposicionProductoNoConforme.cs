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

    public class ADDisposicionProductoNoConforme{

        public void insertarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Producto_No_Conforme", disposicion_Producto_No_Conforme.Id_Producto_No_Conforme));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Disposicion", disposicion_Producto_No_Conforme.Fecha_Disposicion));
            cmd.Parameters.Add(new SqlParameter("@Disposicion_Final", disposicion_Producto_No_Conforme.Disposicion_Final));
            cmd.Parameters.Add(new SqlParameter("@Tanque_Destino", disposicion_Producto_No_Conforme.Tanque_Destino));
            cmd.Parameters.Add(new SqlParameter("@Se_Dispone", disposicion_Producto_No_Conforme.Se_Dispone));
            cmd.Parameters.Add(new SqlParameter("@Disposicion_Empaque", disposicion_Producto_No_Conforme.Disposicion_Empaque));
            cmd.Parameters.Add(new SqlParameter("@Lote_Reproceso_Producto", disposicion_Producto_No_Conforme.Lote_Reproceso_Producto));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", disposicion_Producto_No_Conforme.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@Estado", disposicion_Producto_No_Conforme.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", disposicion_Producto_No_Conforme.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", disposicion_Producto_No_Conforme.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", disposicion_Producto_No_Conforme.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", disposicion_Producto_No_Conforme.Fecha_Modificacion));
            cmd.CommandText = "InsertarDisposicionProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Disposicion_Producto_No_Conforme", disposicion_Producto_No_Conforme.Id_Disposicion_Producto_No_Conforme));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Producto_No_Conforme", disposicion_Producto_No_Conforme.Id_Producto_No_Conforme));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Disposicion", disposicion_Producto_No_Conforme.Fecha_Disposicion));
            cmd.Parameters.Add(new SqlParameter("@Disposicion_Final", disposicion_Producto_No_Conforme.Disposicion_Final));
            cmd.Parameters.Add(new SqlParameter("@Tanque_Destino", disposicion_Producto_No_Conforme.Tanque_Destino));
            cmd.Parameters.Add(new SqlParameter("@Se_Dispone", disposicion_Producto_No_Conforme.Se_Dispone));
            cmd.Parameters.Add(new SqlParameter("@Disposicion_Empaque", disposicion_Producto_No_Conforme.Disposicion_Empaque));
            cmd.Parameters.Add(new SqlParameter("@Lote_Reproceso_Producto", disposicion_Producto_No_Conforme.Lote_Reproceso_Producto));
            cmd.Parameters.Add(new SqlParameter("@Observaciones", disposicion_Producto_No_Conforme.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@Estado", disposicion_Producto_No_Conforme.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", disposicion_Producto_No_Conforme.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", disposicion_Producto_No_Conforme.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", disposicion_Producto_No_Conforme.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", disposicion_Producto_No_Conforme.Fecha_Modificacion));
            cmd.CommandText = "ActualizarDisposicionProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Disposicion_Producto_No_Conforme", Id_Disposicion_Producto_No_Conforme));
            cmd.CommandText = "EliminarDisposicionProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Disposicion_Producto_No_Conforme> buscarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Disposicion_Producto_No_Conforme", Id_Disposicion_Producto_No_Conforme));
            cmd.CommandText = "ConsultarDisposicionProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Disposicion_Producto_No_Conforme> lista = new List<Disposicion_Producto_No_Conforme>();
            Disposicion_Producto_No_Conforme disposicionProductoNoConforme = new Disposicion_Producto_No_Conforme();

            while (dr.Read()){

                disposicionProductoNoConforme.Id_Disposicion_Producto_No_Conforme = Convert.ToInt32(dr["Id_Disposicion_Producto_No_Conforme"].ToString());
                disposicionProductoNoConforme.Id_Producto_No_Conforme = Convert.ToInt32(dr["FK_Id_Producto_No_Conforme"].ToString());
                disposicionProductoNoConforme.Fecha_Disposicion = Convert.ToDateTime(dr["Fecha_Disposicion"].ToString());
                disposicionProductoNoConforme.Disposicion_Final = dr["Disposicion_Final"].ToString();
                disposicionProductoNoConforme.Tanque_Destino = Convert.ToInt32(dr["Tanque_Destino"].ToString());
                disposicionProductoNoConforme.Se_Dispone = dr["Se_Dispone"].ToString();
                disposicionProductoNoConforme.Disposicion_Empaque = dr["Disposicion_Empaque"].ToString();
                disposicionProductoNoConforme.Lote_Reproceso_Producto = dr["Lote_Reproceso_Producto"].ToString();
                disposicionProductoNoConforme.Observaciones = dr["Observaciones"].ToString();
                disposicionProductoNoConforme.Estado = dr["Estado"].ToString();
                disposicionProductoNoConforme.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                disposicionProductoNoConforme.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                disposicionProductoNoConforme.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                disposicionProductoNoConforme.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(disposicionProductoNoConforme);
            }
            aux.conectar();
            return lista;
        }

        public List<Disposicion_Producto_No_Conforme> listarDisposicionProductoNoConforme(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarDisposicionProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Disposicion_Producto_No_Conforme> lista = new List<Disposicion_Producto_No_Conforme>();

            while (dr.Read()){

                Disposicion_Producto_No_Conforme disposicionProductoNoConforme = new Disposicion_Producto_No_Conforme();

                disposicionProductoNoConforme.Id_Disposicion_Producto_No_Conforme = Convert.ToInt32(dr["Id_Disposicion_Producto_No_Conforme"].ToString());
                disposicionProductoNoConforme.Id_Producto_No_Conforme = Convert.ToInt32(dr["FK_Id_Producto_No_Conforme"].ToString());
                disposicionProductoNoConforme.Fecha_Disposicion = Convert.ToDateTime(dr["Fecha_Disposicion"].ToString());
                disposicionProductoNoConforme.Disposicion_Final = dr["Disposicion_Final"].ToString();
                disposicionProductoNoConforme.Tanque_Destino = Convert.ToInt32(dr["Tanque_Destino"].ToString());
                disposicionProductoNoConforme.Se_Dispone = dr["Se_Dispone"].ToString();
                disposicionProductoNoConforme.Disposicion_Empaque = dr["Disposicion_Empaque"].ToString();
                disposicionProductoNoConforme.Lote_Reproceso_Producto = dr["Lote_Reproceso_Producto"].ToString();
                disposicionProductoNoConforme.Observaciones = dr["Observaciones"].ToString();
                disposicionProductoNoConforme.Estado = dr["Estado"].ToString();
                disposicionProductoNoConforme.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                disposicionProductoNoConforme.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                disposicionProductoNoConforme.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                disposicionProductoNoConforme.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(disposicionProductoNoConforme);
            }
            aux.conectar();
            return lista;

        }

    }
}
