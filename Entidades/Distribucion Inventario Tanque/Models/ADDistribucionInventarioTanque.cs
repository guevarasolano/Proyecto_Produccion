using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Distribucion_Inventario_Tanque.Models { 

    public class ADDistribucionInventarioTanque{

        //METODO PARA INSERTAR DISTRIBUCION INVENTARIO TANQUE:
        public Boolean insertarDistribucionInventarioTanque(DistribucionInventarioTanque inventario_Producto_Terminado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Brix", inventario_Producto_Terminado.FK_Id_Brix));
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", inventario_Producto_Terminado.Numero_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Litros", inventario_Producto_Terminado.Litros));
            cmd.Parameters.Add(new SqlParameter("@Kilogramos_Tanque", inventario_Producto_Terminado.Kilogramos_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Estañones", inventario_Producto_Terminado.Estimado_Cantidad_Estañones));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Bines", inventario_Producto_Terminado.Estimado_Cantidad_Bines));
            cmd.Parameters.Add(new SqlParameter("@Estado", inventario_Producto_Terminado.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", inventario_Producto_Terminado.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", inventario_Producto_Terminado.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", inventario_Producto_Terminado.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", inventario_Producto_Terminado.Fecha_Modificacion));
            cmd.CommandText = "InsertarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //METODO PARA ACTUALIZAR DISTRIBUCION INVENTARIO TANQUE:
        public void actualizarDistribucionInventarioTanque(DistribucionInventarioTanque inventario_Producto_Terminado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Distribucion_Inventario_Tanque", inventario_Producto_Terminado.Id_Distribucion_Inventario_Tanque));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Brix", inventario_Producto_Terminado.FK_Id_Brix));
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", inventario_Producto_Terminado.Numero_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Litros", inventario_Producto_Terminado.Litros));
            cmd.Parameters.Add(new SqlParameter("@Kilogramos_Tanque", inventario_Producto_Terminado.Kilogramos_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Estañones", inventario_Producto_Terminado.Estimado_Cantidad_Estañones));
            cmd.Parameters.Add(new SqlParameter("@Estimado_Cantidad_Bines", inventario_Producto_Terminado.Estimado_Cantidad_Bines));
            cmd.Parameters.Add(new SqlParameter("@Estado", inventario_Producto_Terminado.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", inventario_Producto_Terminado.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", inventario_Producto_Terminado.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", inventario_Producto_Terminado.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", inventario_Producto_Terminado.Fecha_Modificacion));
            cmd.CommandText = "ActualizarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        //METODO PARA ELIMINAR DISTRIBUCION INVENTARIO TANQUE:
        public Boolean eliminarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Distribucion_Inventario_Tanque", Id_Distribucion_Inventario_Tanque));
            cmd.CommandText = "EliminarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //METODO PARA BUSCAR DISTRIBUCION INVENTARIO TANQUE:
        public DistribucionInventarioTanque buscarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque){

            DistribucionInventarioTanque inventarioProductoTerminado = new DistribucionInventarioTanque();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Distribucion_Inventario_Tanque", Id_Distribucion_Inventario_Tanque));
            cmd.CommandText = "ConsultarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                inventarioProductoTerminado.Id_Distribucion_Inventario_Tanque = Convert.ToInt32(dr["Id_Distribucion_Inventario_Tanque"].ToString());
                inventarioProductoTerminado.FK_Id_Brix = Convert.ToInt32(dr["FK_Id_Brix"].ToString());
                inventarioProductoTerminado.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
                inventarioProductoTerminado.Litros = Convert.ToDouble(dr["Litros"].ToString());
                inventarioProductoTerminado.Kilogramos_Tanque = Convert.ToDouble(dr["Kilogramos_Tanque"].ToString());
                inventarioProductoTerminado.Estimado_Cantidad_Estañones = Convert.ToInt32(dr["Estimado_Cantidad_Estañones"].ToString());
                inventarioProductoTerminado.Estimado_Cantidad_Bines = Convert.ToInt32(dr["Estimado_Cantidad_Bines"].ToString());
                inventarioProductoTerminado.Estado = dr["Estado"].ToString();
                inventarioProductoTerminado.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                inventarioProductoTerminado.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                inventarioProductoTerminado.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                inventarioProductoTerminado.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                inventarioProductoTerminado = null;
            }
            aux.conectar();
            return inventarioProductoTerminado;
        }

        //METODO PARA LISTAR DISTRIBUCION INVENTARIO TANQUE:
        public List<DistribucionInventarioTanque> listarDistribucionInventarioTanque(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarDistribucionInventarioTanque";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<DistribucionInventarioTanque> lista = new List<DistribucionInventarioTanque>();

            while (dr.Read()){

                DistribucionInventarioTanque inventarioProductoTerminado = new DistribucionInventarioTanque();

                inventarioProductoTerminado.Id_Distribucion_Inventario_Tanque = Convert.ToInt32(dr["Id_Distribucion_Inventario_Tanque"].ToString());
                inventarioProductoTerminado.FK_Id_Brix = Convert.ToInt32(dr["FK_Id_Brix"].ToString());
                inventarioProductoTerminado.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
                inventarioProductoTerminado.Litros = Convert.ToDouble(dr["Litros"].ToString());
                inventarioProductoTerminado.Kilogramos_Tanque = Convert.ToDouble(dr["Kilogramos_Tanque"].ToString());
                inventarioProductoTerminado.Estimado_Cantidad_Estañones = Convert.ToInt32(dr["Estimado_Cantidad_Estañones"].ToString());
                inventarioProductoTerminado.Estimado_Cantidad_Bines = Convert.ToInt32(dr["Estimado_Cantidad_Bines"].ToString());
                inventarioProductoTerminado.Estado = dr["Estado"].ToString();
                inventarioProductoTerminado.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                inventarioProductoTerminado.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                inventarioProductoTerminado.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                inventarioProductoTerminado.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(inventarioProductoTerminado);
            }
            aux.conectar();
            return lista;

        }

    }

}