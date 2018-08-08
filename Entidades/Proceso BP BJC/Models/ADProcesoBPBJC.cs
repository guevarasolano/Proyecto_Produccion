using AccesoDatos;
using Proceso_BP_BJC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba{

    public class ADProcesoBPBJC{

        public Boolean insertarProcesoBPBJC(ProcesoBPBJC proceso_BP_BJC){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Tipo_Producto", proceso_BP_BJC.Tipo_Producto));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Producto_Total", proceso_BP_BJC.Cantidad_Producto_Total));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Llenado", proceso_BP_BJC.Porcentaje_Llenado));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Cajas_Usadas", proceso_BP_BJC.Cantidad_Cajas_Usadas));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Carga_Banano_Verde_Usado_Kg", proceso_BP_BJC.Cantidad_Carga_Banano_Verde_Usado_Kg)); 
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Carga_Banano_Maduro_Usado_Kg", proceso_BP_BJC.Cantidad_Carga_Banano_Maduro_Usado_Kg));
            cmd.Parameters.Add(new SqlParameter("@Litros_Producidos", proceso_BP_BJC.Litros_Producidos));
            cmd.Parameters.Add(new SqlParameter("@Transferido_Tanque", proceso_BP_BJC.Transferido_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Estado", proceso_BP_BJC.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_BP_BJC.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_BP_BJC.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_BP_BJC.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_BP_BJC.Fecha_Modificacion));
            cmd.CommandText = "InsertarProcesoBPBJC";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        public void actualizarProcesoBPBJC(ProcesoBPBJC proceso_BP_BJC){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_BP_BJC", proceso_BP_BJC.Id_Proceso_BP_BJC));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Producto", proceso_BP_BJC.Tipo_Producto));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Producto_Total", proceso_BP_BJC.Cantidad_Producto_Total));
            cmd.Parameters.Add(new SqlParameter("@Porcentaje_Llenado", proceso_BP_BJC.Porcentaje_Llenado));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Cajas_Usadas", proceso_BP_BJC.Cantidad_Cajas_Usadas));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Carga_Banano_Verde_Usado_Kg", proceso_BP_BJC.Cantidad_Carga_Banano_Verde_Usado_Kg));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Carga_Banano_Maduro_Usado_Kg", proceso_BP_BJC.Cantidad_Carga_Banano_Maduro_Usado_Kg));
            cmd.Parameters.Add(new SqlParameter("@Litros_Producidos", proceso_BP_BJC.Litros_Producidos));
            cmd.Parameters.Add(new SqlParameter("@Transferido_Tanque", proceso_BP_BJC.Transferido_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Estado", proceso_BP_BJC.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_BP_BJC.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_BP_BJC.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_BP_BJC.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_BP_BJC.Fecha_Modificacion));
            cmd.CommandText = "ActualizarProcesoBPBJC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public Boolean eliminarProcesoBPBJC(int Id_Proceso_BP_BJC){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_BP_BJC", Id_Proceso_BP_BJC));
            cmd.CommandText = "EliminarProcesoBPBJC";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        public ProcesoBPBJC buscarProcesoBPBJC(int Id_Proceso_BP_BJC){

            ProcesoBPBJC proceso_BP_BJC = new ProcesoBPBJC();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_BP_BJC", Id_Proceso_BP_BJC));
            cmd.CommandText = "ConsultarProcesoBPBJC";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();            

            if (dr.Read()){

                proceso_BP_BJC.Id_Proceso_BP_BJC = Convert.ToInt32(dr["Id_Proceso_BP_BJC"].ToString());
                proceso_BP_BJC.Tipo_Producto = dr["Tipo_Producto"].ToString();
                proceso_BP_BJC.Cantidad_Producto_Total = Convert.ToInt32(dr["Cantidad_Producto_Total"].ToString());
                proceso_BP_BJC.Porcentaje_Llenado = Convert.ToInt32(dr["Porcentaje_Llenado"].ToString());
                proceso_BP_BJC.Cantidad_Cajas_Usadas = Convert.ToInt32(dr["Cantidad_Cajas_Usadas"].ToString());
                proceso_BP_BJC.Cantidad_Carga_Banano_Verde_Usado_Kg = Convert.ToDouble(dr["Cantidad_Carga_Banano_Verde_Usado_Kg"].ToString());
                proceso_BP_BJC.Cantidad_Carga_Banano_Maduro_Usado_Kg = Convert.ToDouble(dr["Cantidad_Carga_Banano_Maduro_Usado_Kg"].ToString());
                proceso_BP_BJC.Litros_Producidos = Convert.ToInt32(dr["Litros_Producidos"].ToString());
                proceso_BP_BJC.Transferido_Tanque = Convert.ToInt32(dr["Transferido_Tanque"].ToString());
                proceso_BP_BJC.Estado = dr["Estado"].ToString();
                proceso_BP_BJC.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_BP_BJC.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_BP_BJC.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_BP_BJC.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                proceso_BP_BJC = null;
            }
            aux.conectar();
            return proceso_BP_BJC;
        }

        public List<ProcesoBPBJC> listarProcesoBPBJC(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarProcesoBPBJC";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<ProcesoBPBJC> lista = new List<ProcesoBPBJC>();

            while (dr.Read()){

                ProcesoBPBJC proceso_BP_BJC = new ProcesoBPBJC();

                proceso_BP_BJC.Id_Proceso_BP_BJC = Convert.ToInt32(dr["Id_Proceso_BP_BJC"].ToString());
                proceso_BP_BJC.Tipo_Producto = dr["Tipo_Producto"].ToString();
                proceso_BP_BJC.Cantidad_Producto_Total = Convert.ToInt32(dr["Cantidad_Producto_Total"].ToString());
                proceso_BP_BJC.Porcentaje_Llenado = Convert.ToInt32(dr["Porcentaje_Llenado"].ToString());
                proceso_BP_BJC.Cantidad_Cajas_Usadas = Convert.ToInt32(dr["Cantidad_Cajas_Usadas"].ToString());
                proceso_BP_BJC.Cantidad_Carga_Banano_Verde_Usado_Kg = Convert.ToDouble(dr["Cantidad_Carga_Banano_Verde_Usado_Kg"].ToString());
                proceso_BP_BJC.Cantidad_Carga_Banano_Maduro_Usado_Kg = Convert.ToDouble(dr["Cantidad_Carga_Banano_Maduro_Usado_Kg"].ToString());
                proceso_BP_BJC.Litros_Producidos = Convert.ToInt32(dr["Litros_Producidos"].ToString());
                proceso_BP_BJC.Transferido_Tanque = Convert.ToInt32(dr["Transferido_Tanque"].ToString());
                proceso_BP_BJC.Estado = dr["Estado"].ToString();
                proceso_BP_BJC.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_BP_BJC.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_BP_BJC.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_BP_BJC.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(proceso_BP_BJC);
            }
            aux.conectar();
            return lista;
        }


    }
}
