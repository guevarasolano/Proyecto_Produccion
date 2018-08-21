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

    public class ADDistribucionInventarioTanque{

        public void insertarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Brix", distribucion_Inventario_Tanque.Id_Brix));
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", distribucion_Inventario_Tanque.Numero_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Litros", distribucion_Inventario_Tanque.Litros));
            cmd.Parameters.Add(new SqlParameter("@Kilogramos_Tanque", distribucion_Inventario_Tanque.Kilogramos_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Estañones", distribucion_Inventario_Tanque.Estimado_Cantidad_Estañones));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Bines", distribucion_Inventario_Tanque.Estimado_Cantidad_Bines));
            cmd.Parameters.Add(new SqlParameter("@Estado", distribucion_Inventario_Tanque.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", distribucion_Inventario_Tanque.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", distribucion_Inventario_Tanque.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", distribucion_Inventario_Tanque.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", distribucion_Inventario_Tanque.Fecha_Modificacion));
            cmd.CommandText = "InsertarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Distribucion_Inventario_Tanque", distribucion_Inventario_Tanque.Id_Distribucion_Inventario_Tanque));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Brix", distribucion_Inventario_Tanque.Id_Brix));
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", distribucion_Inventario_Tanque.Numero_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Litros", distribucion_Inventario_Tanque.Litros));
            cmd.Parameters.Add(new SqlParameter("@Kilogramos_Tanque", distribucion_Inventario_Tanque.Kilogramos_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Estañones", distribucion_Inventario_Tanque.Estimado_Cantidad_Estañones));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Bines", distribucion_Inventario_Tanque.Estimado_Cantidad_Bines));
            cmd.Parameters.Add(new SqlParameter("@Estado", distribucion_Inventario_Tanque.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", distribucion_Inventario_Tanque.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", distribucion_Inventario_Tanque.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", distribucion_Inventario_Tanque.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", distribucion_Inventario_Tanque.Fecha_Modificacion));
            cmd.CommandText = "ActualizarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Distribucion_Inventario_Tanque", Id_Distribucion_Inventario_Tanque));
            cmd.CommandText = "EliminarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Distribucion_Inventario_Tanque> buscarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Distribucion_Inventario_Tanque", Id_Distribucion_Inventario_Tanque));
            cmd.CommandText = "ConsultarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Distribucion_Inventario_Tanque> lista = new List<Distribucion_Inventario_Tanque>();
            Distribucion_Inventario_Tanque distribucion_Inventario_Tanque = new Distribucion_Inventario_Tanque();

            while (dr.Read()){

                distribucion_Inventario_Tanque.Id_Distribucion_Inventario_Tanque = Convert.ToInt32(dr["Id_Distribucion_Inventario_Tanque"].ToString());
                distribucion_Inventario_Tanque.Id_Brix = Convert.ToInt32(dr["FK_Id_Brix"].ToString());
                distribucion_Inventario_Tanque.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
                distribucion_Inventario_Tanque.Litros = Convert.ToDouble(dr["Litros"].ToString());
                distribucion_Inventario_Tanque.Kilogramos_Tanque = Convert.ToDouble(dr["Kilogramos_Tanque"].ToString());
                distribucion_Inventario_Tanque.Estimado_Cantidad_Estañones = Convert.ToInt32(dr["Estimado_Cantidad_Estañones"].ToString());
                distribucion_Inventario_Tanque.Estimado_Cantidad_Bines = Convert.ToInt32(dr["Estimado_Cantidad_Bines"].ToString());
                distribucion_Inventario_Tanque.Estado = dr["Estado"].ToString();
                distribucion_Inventario_Tanque.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                distribucion_Inventario_Tanque.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                distribucion_Inventario_Tanque.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                distribucion_Inventario_Tanque.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(distribucion_Inventario_Tanque);
            }
            aux.conectar();
            return lista;
        }

        public List<Distribucion_Inventario_Tanque> listarDistribucionInventarioTanque(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Distribucion_Inventario_Tanque> lista = new List<Distribucion_Inventario_Tanque>();

            while (dr.Read()){

                Distribucion_Inventario_Tanque distribucion_Inventario_Tanque = new Distribucion_Inventario_Tanque();

                distribucion_Inventario_Tanque.Id_Distribucion_Inventario_Tanque = Convert.ToInt32(dr["Id_Distribucion_Inventario_Tanque"].ToString());
                distribucion_Inventario_Tanque.Id_Brix = Convert.ToInt32(dr["FK_Id_Brix"].ToString());
                distribucion_Inventario_Tanque.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
                distribucion_Inventario_Tanque.Litros = Convert.ToDouble(dr["Litros"].ToString());
                distribucion_Inventario_Tanque.Kilogramos_Tanque = Convert.ToDouble(dr["Kilogramos_Tanque"].ToString());
                distribucion_Inventario_Tanque.Estimado_Cantidad_Estañones = Convert.ToInt32(dr["Estimado_Cantidad_Estañones"].ToString());
                distribucion_Inventario_Tanque.Estimado_Cantidad_Bines = Convert.ToInt32(dr["Estimado_Cantidad_Bines"].ToString());
                distribucion_Inventario_Tanque.Estado = dr["Estado"].ToString();
                distribucion_Inventario_Tanque.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                distribucion_Inventario_Tanque.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                distribucion_Inventario_Tanque.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                distribucion_Inventario_Tanque.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(distribucion_Inventario_Tanque);
            }
            aux.conectar();
            return lista;

        }

        public List<Distribucion_Inventario_Tanque> buscarDistribucionPorTanque(int Numero_Tanque){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", Numero_Tanque));
            cmd.CommandText = "ConsultarDistribucionPorNumeroTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Distribucion_Inventario_Tanque> lista = new List<Distribucion_Inventario_Tanque>();
            Distribucion_Inventario_Tanque distribucion_Inventario_Tanque = new Distribucion_Inventario_Tanque();

            while (dr.Read()){

                distribucion_Inventario_Tanque.Id_Distribucion_Inventario_Tanque = Convert.ToInt32(dr["Id_Distribucion_Inventario_Tanque"].ToString());
                distribucion_Inventario_Tanque.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
                distribucion_Inventario_Tanque.Litros = Convert.ToDouble(dr["Litros"].ToString());
                distribucion_Inventario_Tanque.Kilogramos_Tanque = Convert.ToDouble(dr["Kilogramos_Tanque"].ToString());
                distribucion_Inventario_Tanque.Estimado_Cantidad_Estañones = Convert.ToInt32(dr["Estimado_Cantidad_Estañones"].ToString());
                distribucion_Inventario_Tanque.Estimado_Cantidad_Bines = Convert.ToInt32(dr["Estimado_Cantidad_Bines"].ToString());
                distribucion_Inventario_Tanque.Estado = dr["Estado"].ToString();
                distribucion_Inventario_Tanque.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                distribucion_Inventario_Tanque.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                distribucion_Inventario_Tanque.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                distribucion_Inventario_Tanque.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(distribucion_Inventario_Tanque);
            }
            aux.conectar();
            return lista;
        }

    }
}
