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

    public class ADProcesoMaduracion{

        public void insertarProcesoMaduracion(Proceso_Maduracion proceso_Maduracion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Numero_Recibo", proceso_Maduracion.Numero_Recibo));
            cmd.Parameters.Add(new SqlParameter("@Numero_Carga", proceso_Maduracion.Numero_Carga));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Entrada_Camara", proceso_Maduracion.Fecha_Entrada_Camara));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Banano_Ingreso_Kg", proceso_Maduracion.Cantidad_Banano_Ingreso_Kg));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Banano_Maduro_Kg", proceso_Maduracion.Cantidad_Banano_Maduro_Kg));
            cmd.Parameters.Add(new SqlParameter("@Total_Cajas", proceso_Maduracion.Total_Cajas));
            cmd.Parameters.Add(new SqlParameter("@Total_Cajas_Bloqueadas", proceso_Maduracion.Total_Cajas_Bloqueadas));
            cmd.Parameters.Add(new SqlParameter("@Estado", proceso_Maduracion.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_Maduracion.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_Maduracion.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_Maduracion.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_Maduracion.Fecha_Modificacion));
            cmd.CommandText = "InsertarProcesoMaduracion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarProcesoMaduracion(Proceso_Maduracion proceso_Maduracion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Maduracion", proceso_Maduracion.Id_Proceso_Maduracion));
            cmd.Parameters.Add(new SqlParameter("@Numero_Recibo", proceso_Maduracion.Numero_Recibo));
            cmd.Parameters.Add(new SqlParameter("@Numero_Carga", proceso_Maduracion.Numero_Carga));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Entrada_Camara", proceso_Maduracion.Fecha_Entrada_Camara));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Banano_Ingreso_Kg", proceso_Maduracion.Cantidad_Banano_Ingreso_Kg));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Banano_Maduro_Kg", proceso_Maduracion.Cantidad_Banano_Maduro_Kg));
            cmd.Parameters.Add(new SqlParameter("@Total_Cajas", proceso_Maduracion.Total_Cajas));
            cmd.Parameters.Add(new SqlParameter("@Total_Cajas_Bloqueadas", proceso_Maduracion.Total_Cajas_Bloqueadas));
            cmd.Parameters.Add(new SqlParameter("@Estado", proceso_Maduracion.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_Maduracion.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_Maduracion.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_Maduracion.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_Maduracion.Fecha_Modificacion));
            cmd.CommandText = "ActualizarProcesoMaduracion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarProcesoMaduracion(int Id_Proceso_Maduracion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Maduracion", Id_Proceso_Maduracion));
            cmd.CommandText = "EliminarProcesoMaduracion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Proceso_Maduracion> buscarProcesoMaduracion(int Id_Proceso_Maduracion){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Maduracion", Id_Proceso_Maduracion));
            cmd.CommandText = "ConsultarProcesoMaduracion";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Proceso_Maduracion> lista = new List<Proceso_Maduracion>();
            Proceso_Maduracion proceso_Maduracion = new Proceso_Maduracion();

            while (dr.Read()){

                proceso_Maduracion.Id_Proceso_Maduracion = Convert.ToInt32(dr["Id_Proceso_Maduracion"].ToString());
                proceso_Maduracion.Numero_Recibo = Convert.ToInt32(dr["Numero_Recibo"].ToString());
                proceso_Maduracion.Numero_Carga = dr["Numero_Carga"].ToString();
                proceso_Maduracion.Fecha_Entrada_Camara = Convert.ToDateTime(dr["Fecha_Entrada_Camara"].ToString());
                proceso_Maduracion.Cantidad_Banano_Ingreso_Kg = Convert.ToDouble(dr["Cantidad_Banano_Ingreso_Kg"].ToString());
                proceso_Maduracion.Cantidad_Banano_Maduro_Kg = Convert.ToDouble(dr["Cantidad_Banano_Maduro_Kg"].ToString());
                proceso_Maduracion.Total_Cajas = Convert.ToInt32(dr["Total_Cajas"].ToString());
                proceso_Maduracion.Total_Cajas_Bloqueadas = Convert.ToInt32(dr["Total_Cajas_Bloqueadas"].ToString());
                proceso_Maduracion.Estado = dr["Estado"].ToString();
                proceso_Maduracion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_Maduracion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_Maduracion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_Maduracion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(proceso_Maduracion);
            }
            aux.conectar();
            return lista;
        }

        public List<Proceso_Maduracion> listarProcesoMaduracion(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarProcesoMaduracion";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Proceso_Maduracion> lista = new List<Proceso_Maduracion>();

            while (dr.Read()){

                Proceso_Maduracion proceso_Maduracion = new Proceso_Maduracion();

                proceso_Maduracion.Id_Proceso_Maduracion = Convert.ToInt32(dr["Id_Proceso_Maduracion"].ToString());
                proceso_Maduracion.Numero_Recibo = Convert.ToInt32(dr["Numero_Recibo"].ToString());
                proceso_Maduracion.Numero_Carga = dr["Numero_Carga"].ToString();
                proceso_Maduracion.Fecha_Entrada_Camara = Convert.ToDateTime(dr["Fecha_Entrada_Camara"].ToString());
                proceso_Maduracion.Cantidad_Banano_Ingreso_Kg = Convert.ToDouble(dr["Cantidad_Banano_Ingreso_Kg"].ToString());
                proceso_Maduracion.Cantidad_Banano_Maduro_Kg = Convert.ToDouble(dr["Cantidad_Banano_Maduro_Kg"].ToString());
                proceso_Maduracion.Total_Cajas = Convert.ToInt32(dr["Total_Cajas"].ToString());
                proceso_Maduracion.Total_Cajas_Bloqueadas = Convert.ToInt32(dr["Total_Cajas_Bloqueadas"].ToString());
                proceso_Maduracion.Estado = dr["Estado"].ToString();
                proceso_Maduracion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                proceso_Maduracion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                proceso_Maduracion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                proceso_Maduracion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(proceso_Maduracion);
            }
            aux.conectar();
            return lista;

        }

    }
}
