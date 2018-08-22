using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CapaEntidades;

namespace AccesoDatos{

    public class ADSAPProduccionInfo{

        //MÉTODO PARA INSERTAR SAP PRODUCCIÓN INFO:
        public Boolean insertarSAPProduccionInfo(SAPProduccionInfo sap){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Orden_Fabricacion", sap.Id_Orden_Fabricacion));
            cmd.Parameters.Add(new SqlParameter("@Id_Recibo_Producccion", sap.Id_Recibo_Produccion));
            cmd.Parameters.Add(new SqlParameter("@Id_Emision_Produccion", sap.Id_Emision_Produccion));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Fruta", sap.Tipo_Fruta));
            cmd.Parameters.Add(new SqlParameter("@Estado", sap.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", sap.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", sap.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", sap.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", sap.Fecha_Modificacion));
            cmd.CommandText = "InsertarSAPProduccionInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA ACTUALIZAR SAP PRODUCCIÓN INFO:
        public void actualizarSAPProduccionInfo(SAPProduccionInfo sap){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_SAP_Produccion_Info", sap.Id_SAP_Produccion_Info));
            cmd.Parameters.Add(new SqlParameter("@Id_Orden_Fabricacion", sap.Id_Orden_Fabricacion));
            cmd.Parameters.Add(new SqlParameter("@Id_Recibo_Producccion", sap.Id_Recibo_Produccion));
            cmd.Parameters.Add(new SqlParameter("@Id_Emision_Produccion", sap.Id_Emision_Produccion));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Fruta", sap.Tipo_Fruta));
            cmd.Parameters.Add(new SqlParameter("@Estado", sap.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", sap.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", sap.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", sap.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", sap.Fecha_Modificacion));
            cmd.CommandText = "ActualizarSAPProduccionInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        //MÉTODO PARA ELIMINAR SAP PRODUCCIÓN INFO:
        public bool eliminarSAPProduccionInfo(int Id_SAP_Produccion_Info){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_SAP_Produccion_Info", Id_SAP_Produccion_Info));
            cmd.CommandText = "EliminarSAPProduccionInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA BUSCAR SAP PRODUCCIÓN INFO:
        public SAPProduccionInfo buscarSAPProduccionInfo(int Id_SAP_Produccion_Info){

            SAPProduccionInfo sap = new SAPProduccionInfo();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_SAP_Produccion_Info", Id_SAP_Produccion_Info));
            cmd.CommandText = "ConsultarSAPProduccionInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                sap.Id_SAP_Produccion_Info = Convert.ToInt32(dr["Id_SAP_Produccion_Info"].ToString());
                sap.Id_Orden_Fabricacion = Convert.ToInt32(dr["Id_Orden_Fabricacion"].ToString());
                sap.Id_Recibo_Produccion = Convert.ToInt32(dr["Id_Recibo_Produccion"].ToString());
                sap.Id_Emision_Produccion= Convert.ToInt32(dr["Id_Emision_Produccion"].ToString());
                sap.Tipo_Fruta = dr["Tipo_Fruta"].ToString();
                sap.Estado = dr["Estado"].ToString();
                sap.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                sap.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                sap.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                sap.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                sap = null;
            }
            aux.conectar();
            return sap;
        }

        //MÉTODO PARA LISTAR SAP PRODUCCIÓN INFO:
        public List<SAPProduccionInfo> listarSAPProduccionInfo(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarSAPProduccionInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<SAPProduccionInfo> lista = new List<SAPProduccionInfo>();

            while (dr.Read()){

                SAPProduccionInfo sap = new SAPProduccionInfo();

                sap.Id_SAP_Produccion_Info = Convert.ToInt32(dr["Id_SAP_Produccion_Info"].ToString());
                sap.Id_Orden_Fabricacion = Convert.ToInt32(dr["Id_Orden_Fabricacion"].ToString());
                sap.Id_Recibo_Produccion = Convert.ToInt32(dr["Id_Recibo_Produccion"].ToString());
                sap.Id_Emision_Produccion = Convert.ToInt32(dr["Id_Emision_Produccion"].ToString());
                sap.Tipo_Fruta = dr["Tipo_Fruta"].ToString();
                sap.Estado = dr["Estado"].ToString();
                sap.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                sap.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                sap.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                sap.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(sap);
            }
            aux.conectar();
            return lista;
        }

    }
}