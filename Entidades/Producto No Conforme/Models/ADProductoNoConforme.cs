using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto_No_Conforme.Models{

    public class ADProductoNoConforme{

        public Boolean insertarProductoNoConforme(ProductoNoConforme producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_SAP", producto_No_Conforme.FK_Id_Articulo_SAP));
            cmd.Parameters.Add(new SqlParameter("@Lote_Producto", producto_No_Conforme.Lote_Producto));
            cmd.Parameters.Add(new SqlParameter("@Numero_Unidad", producto_No_Conforme.Numero_Unidad));
            cmd.Parameters.Add(new SqlParameter("@Peso_Toneladas_Metricas", producto_No_Conforme.Peso_Toneladas_Metricas));
            cmd.Parameters.Add(new SqlParameter("@Responsable", producto_No_Conforme.Responsable));
            cmd.Parameters.Add(new SqlParameter("@Llenadora", producto_No_Conforme.Llenadora));
            cmd.Parameters.Add(new SqlParameter("@Empaque", producto_No_Conforme.Empaque));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Producto", producto_No_Conforme.Tipo_Producto));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Bloqueo", producto_No_Conforme.Fecha_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Area_Bloqueo", producto_No_Conforme.Area_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Naturaleza_Bloqueo", producto_No_Conforme.Naturaleza_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Hallazgo", producto_No_Conforme.Hallazgo));
            cmd.Parameters.Add(new SqlParameter("@Causa", producto_No_Conforme.Causa));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Bloqueo", producto_No_Conforme.Codigo_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Estado_Unidad", producto_No_Conforme.Estado_Unidad));
            cmd.Parameters.Add(new SqlParameter("@Disposicion_Recomendada", producto_No_Conforme.Disposicion_Recomendada));
            cmd.Parameters.Add(new SqlParameter("@Estado", producto_No_Conforme.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", producto_No_Conforme.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", producto_No_Conforme.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", producto_No_Conforme.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", producto_No_Conforme.Fecha_Modificacion));
            cmd.CommandText = "InsertarProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        public void actualizarProductoNoConforme(ProductoNoConforme producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Producto_No_Conforme", producto_No_Conforme.Id_Producto_No_Conforme));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_SAP", producto_No_Conforme.FK_Id_Articulo_SAP));
            cmd.Parameters.Add(new SqlParameter("@Lote_Producto", producto_No_Conforme.Lote_Producto));
            cmd.Parameters.Add(new SqlParameter("@Numero_Unidad", producto_No_Conforme.Numero_Unidad));
            cmd.Parameters.Add(new SqlParameter("@Peso_Toneladas_Metricas", producto_No_Conforme.Peso_Toneladas_Metricas));
            cmd.Parameters.Add(new SqlParameter("@Responsable", producto_No_Conforme.Responsable));
            cmd.Parameters.Add(new SqlParameter("@Llenadora", producto_No_Conforme.Llenadora));
            cmd.Parameters.Add(new SqlParameter("@Empaque", producto_No_Conforme.Empaque));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Producto", producto_No_Conforme.Tipo_Producto));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Bloqueo", producto_No_Conforme.Fecha_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Area_Bloqueo", producto_No_Conforme.Area_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Naturaleza_Bloqueo", producto_No_Conforme.Naturaleza_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Hallazgo", producto_No_Conforme.Hallazgo));
            cmd.Parameters.Add(new SqlParameter("@Causa", producto_No_Conforme.Causa));
            cmd.Parameters.Add(new SqlParameter("@Codigo_Bloqueo", producto_No_Conforme.Codigo_Bloqueo));
            cmd.Parameters.Add(new SqlParameter("@Estado_Unidad", producto_No_Conforme.Estado_Unidad));
            cmd.Parameters.Add(new SqlParameter("@Disposicion_Recomendada", producto_No_Conforme.Disposicion_Recomendada));
            cmd.Parameters.Add(new SqlParameter("@Estado", producto_No_Conforme.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", producto_No_Conforme.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", producto_No_Conforme.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", producto_No_Conforme.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", producto_No_Conforme.Fecha_Modificacion));
            cmd.CommandText = "ActualizarProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public Boolean eliminarProductoNoConforme(int Id_Producto_No_Conforme){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Producto_No_Conforme", Id_Producto_No_Conforme));
            cmd.CommandText = "EliminarProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        public ProductoNoConforme buscarProductoNoConforme(int Id_Producto_No_Conforme){

            ProductoNoConforme productoNoConforme = new ProductoNoConforme();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Producto_No_Conforme", Id_Producto_No_Conforme));
            cmd.CommandText = "ConsultarProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();            

            if (dr.Read()){

                productoNoConforme.Id_Producto_No_Conforme = Convert.ToInt32(dr["Id_Producto_No_Conforme"].ToString());
                productoNoConforme.FK_Id_Articulo_SAP = Convert.ToInt32(dr["FK_Id_Articulo_SAP"].ToString());
                productoNoConforme.Lote_Producto = dr["Lote_Producto"].ToString();
                productoNoConforme.Numero_Unidad = Convert.ToInt32(dr["Numero_Unidad"].ToString());
                productoNoConforme.Peso_Toneladas_Metricas = Convert.ToInt32(dr["Peso_Toneladas_Metricas"].ToString());
                productoNoConforme.Responsable = dr["Responsable"].ToString();
                productoNoConforme.Llenadora = Convert.ToInt32(dr["Llenadora"].ToString());
                productoNoConforme.Empaque = Convert.ToInt32(dr["Empaque"].ToString());
                productoNoConforme.Tipo_Producto = dr["Tipo_Producto"].ToString();
                productoNoConforme.Fecha_Bloqueo = Convert.ToDateTime(dr["Fecha_Bloqueo"].ToString());
                productoNoConforme.Area_Bloqueo = dr["Area_Bloqueo"].ToString();
                productoNoConforme.Naturaleza_Bloqueo = dr["Naturaleza_Bloqueo"].ToString();
                productoNoConforme.Hallazgo = dr["Hallazgo"].ToString();
                productoNoConforme.Causa = dr["Causa"].ToString();
                productoNoConforme.Codigo_Bloqueo = dr["Codigo_Bloqueo"].ToString();
                productoNoConforme.Estado_Unidad = dr["Estado_Unidad"].ToString();
                productoNoConforme.Disposicion_Recomendada = dr["Disposicion_Recomendada"].ToString();
                productoNoConforme.Estado = dr["Estado"].ToString();
                productoNoConforme.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                productoNoConforme.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                productoNoConforme.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                productoNoConforme.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                productoNoConforme = null;
            }
            aux.conectar();
            return productoNoConforme;
        }

        public List<ProductoNoConforme> listarProductoNoConforme(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarProductoNoConforme";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<ProductoNoConforme> lista = new List<ProductoNoConforme>();

            while (dr.Read()){

                ProductoNoConforme productoNoConforme = new ProductoNoConforme();

                productoNoConforme.Id_Producto_No_Conforme = Convert.ToInt32(dr["Id_Producto_No_Conforme"].ToString());
                productoNoConforme.FK_Id_Articulo_SAP = Convert.ToInt32(dr["FK_Id_Articulo_SAP"].ToString());
                productoNoConforme.Lote_Producto = dr["Lote_Producto"].ToString();
                productoNoConforme.Numero_Unidad = Convert.ToInt32(dr["Numero_Unidad"].ToString());
                productoNoConforme.Peso_Toneladas_Metricas = Convert.ToInt32(dr["Peso_Toneladas_Metricas"].ToString());
                productoNoConforme.Responsable = dr["Responsable"].ToString();
                productoNoConforme.Llenadora = Convert.ToInt32(dr["Llenadora"].ToString());
                productoNoConforme.Empaque = Convert.ToInt32(dr["Empaque"].ToString());
                productoNoConforme.Tipo_Producto = dr["Tipo_Producto"].ToString();
                productoNoConforme.Fecha_Bloqueo = Convert.ToDateTime(dr["Fecha_Bloqueo"].ToString());
                productoNoConforme.Area_Bloqueo = dr["Area_Bloqueo"].ToString();
                productoNoConforme.Naturaleza_Bloqueo = dr["Naturaleza_Bloqueo"].ToString();
                productoNoConforme.Hallazgo = dr["Hallazgo"].ToString();
                productoNoConforme.Causa = dr["Causa"].ToString();
                productoNoConforme.Codigo_Bloqueo = dr["Codigo_Bloqueo"].ToString();
                productoNoConforme.Estado_Unidad = dr["Estado_Unidad"].ToString();
                productoNoConforme.Disposicion_Recomendada = dr["Disposicion_Recomendada"].ToString();
                productoNoConforme.Estado = dr["Estado"].ToString();
                productoNoConforme.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                productoNoConforme.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                productoNoConforme.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                productoNoConforme.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(productoNoConforme);
            }
            aux.conectar();
            return lista;
        }

    }
}
