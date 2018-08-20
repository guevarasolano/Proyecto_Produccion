using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditivo.Models { 

    public class ADAditivo{

        //MÉTODO PARA INSERTAR ADITIVO:
        public Boolean insertarAditivo(Aditivo aditivo){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Proceso_BP_BJC", aditivo.FK_Id_Proceso_BP_BJC));
            cmd.Parameters.Add(new SqlParameter("@Jugo_Limon", aditivo.Jugo_Limon));
            cmd.Parameters.Add(new SqlParameter("@Ascorbico", aditivo.Ascorbico));
            cmd.Parameters.Add(new SqlParameter("@Citrico", aditivo.Citrico));
            cmd.Parameters.Add(new SqlParameter("@Liquiseb_RL_Concentrado", aditivo.Liquiseb_RL_Concentrado));
            cmd.Parameters.Add(new SqlParameter("@Liquiseb_APL", aditivo.Liquiseb_APL));
            cmd.Parameters.Add(new SqlParameter("@Sebamyl_GL400", aditivo.Sebamyl_GL400));
            cmd.Parameters.Add(new SqlParameter("@Sebamyl_BAL100", aditivo.Sebamyl_BAL100));
            cmd.Parameters.Add(new SqlParameter("@Flora_Clair", aditivo.Flora_Clair));
            cmd.Parameters.Add(new SqlParameter("@Gelatina", aditivo.Gelatina));
            cmd.Parameters.Add(new SqlParameter("@Bevasyl", aditivo.Bevasyl));
            cmd.Parameters.Add(new SqlParameter("@Bentonita", aditivo.Bentonita));
            cmd.Parameters.Add(new SqlParameter("@Carbon", aditivo.Carbon));
            cmd.Parameters.Add(new SqlParameter("@Celite", aditivo.Celite));
            cmd.Parameters.Add(new SqlParameter("@HS_4000", aditivo.HS_4000));
            cmd.Parameters.Add(new SqlParameter("@Shenck_DD", aditivo.Shenck_DD));
            cmd.Parameters.Add(new SqlParameter("@HS_1000", aditivo.HS_1000));
            cmd.Parameters.Add(new SqlParameter("@HS_1600", aditivo.HS_1600));
            cmd.Parameters.Add(new SqlParameter("@Estado", aditivo.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", aditivo.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", aditivo.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", aditivo.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", aditivo.Fecha_Modificacion));
            cmd.CommandText = "InsertarAditivo";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA ACTUALIZAR ADITIVO:
        public void actualizarAditivo(Aditivo aditivo){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Aditivo", aditivo.Id_Aditivo));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Proceso_BP_BJC", aditivo.FK_Id_Proceso_BP_BJC));
            cmd.Parameters.Add(new SqlParameter("@Jugo_Limon", aditivo.Jugo_Limon));
            cmd.Parameters.Add(new SqlParameter("@Ascorbico", aditivo.Ascorbico));
            cmd.Parameters.Add(new SqlParameter("@Citrico", aditivo.Citrico));
            cmd.Parameters.Add(new SqlParameter("@Liquiseb_RL_Concentrado", aditivo.Liquiseb_RL_Concentrado));
            cmd.Parameters.Add(new SqlParameter("@Liquiseb_APL", aditivo.Liquiseb_APL));
            cmd.Parameters.Add(new SqlParameter("@Sebamyl_GL400", aditivo.Sebamyl_GL400));
            cmd.Parameters.Add(new SqlParameter("@Sebamyl_BAL100", aditivo.Sebamyl_BAL100));
            cmd.Parameters.Add(new SqlParameter("@Flora_Clair", aditivo.Flora_Clair));
            cmd.Parameters.Add(new SqlParameter("@Gelatina", aditivo.Gelatina));
            cmd.Parameters.Add(new SqlParameter("@Bevasyl", aditivo.Bevasyl));
            cmd.Parameters.Add(new SqlParameter("@Bentonita", aditivo.Bentonita));
            cmd.Parameters.Add(new SqlParameter("@Carbon", aditivo.Carbon));
            cmd.Parameters.Add(new SqlParameter("@Celite", aditivo.Celite));
            cmd.Parameters.Add(new SqlParameter("@HS_4000", aditivo.HS_4000));
            cmd.Parameters.Add(new SqlParameter("@Shenck_DD", aditivo.Shenck_DD));
            cmd.Parameters.Add(new SqlParameter("@HS_1000", aditivo.HS_1000));
            cmd.Parameters.Add(new SqlParameter("@HS_1600", aditivo.HS_1600));
            cmd.Parameters.Add(new SqlParameter("@Estado", aditivo.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", aditivo.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", aditivo.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", aditivo.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", aditivo.Fecha_Modificacion));
            cmd.CommandText = "ActualizarAditivo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        //MÉTODO PARA ELIMINAR ADITIVO:
        public Boolean eliminarAditivo(int Id_Aditivo){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Aditivo", Id_Aditivo));
            cmd.CommandText = "EliminarAditivo";
            cmd.CommandType = CommandType.StoredProcedure;
            int x = cmd.ExecuteNonQuery();
            aux.conectar();
            if (x >= 1){
                return true;
            }else{
                return false;
            }
        }

        //MÉTODO PARA BUSCAR ADITIVO:
        public Aditivo buscarAditivo(int Id_Aditivo){

            Aditivo aditivo = new Aditivo();
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Aditivo", Id_Aditivo));
            cmd.CommandText = "ConsultarAditivo";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){

                aditivo.Id_Aditivo = Convert.ToInt32(dr["Id_Aditivo"].ToString());
                aditivo.FK_Id_Proceso_BP_BJC = Convert.ToInt32(dr["FK_Id_Proceso_BP_BJC"].ToString());
                aditivo.Jugo_Limon = Convert.ToDouble(dr["Jugo_Limon"].ToString());
                aditivo.Ascorbico = Convert.ToDouble(dr["Ascorbico"].ToString());
                aditivo.Citrico = Convert.ToDouble(dr["Citrico"].ToString());
                aditivo.Liquiseb_RL_Concentrado = Convert.ToDouble(dr["Liquiseb_RL_Concentrado"].ToString());
                aditivo.Liquiseb_APL = Convert.ToDouble(dr["Liquiseb_APL"].ToString());
                aditivo.Sebamyl_GL400 = Convert.ToDouble(dr["Sebamyl_GL400"].ToString());
                aditivo.Sebamyl_BAL100 = Convert.ToDouble(dr["Sebamyl_BAL100"].ToString());
                aditivo.Flora_Clair = Convert.ToDouble(dr["Flora_Clair"].ToString());
                aditivo.Gelatina = Convert.ToDouble(dr["Gelatina"].ToString());
                aditivo.Bevasyl = Convert.ToDouble(dr["Bevasyl"].ToString());
                aditivo.Bentonita = Convert.ToDouble(dr["Bentonita"].ToString());
                aditivo.Carbon = Convert.ToDouble(dr["Carbon"].ToString());
                aditivo.Celite = Convert.ToDouble(dr["Celite"].ToString());
                aditivo.HS_4000 = Convert.ToDouble(dr["HS_4000"].ToString());
                aditivo.Shenck_DD = Convert.ToDouble(dr["Shenck_DD"].ToString());
                aditivo.HS_1000 = Convert.ToDouble(dr["HS_1000"].ToString());
                aditivo.HS_1600 = Convert.ToDouble(dr["HS_1600"].ToString());
                aditivo.Estado = dr["Estado"].ToString();
                aditivo.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                aditivo.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                aditivo.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                aditivo.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            }else{
                aditivo = null;
            }
            aux.conectar();
            return aditivo;
        }

        //MÉTODO PARA LISTAR ADITIVO:
        public List<Aditivo> listarAditivo(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarAditivo";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Aditivo> lista = new List<Aditivo>();

            while (dr.Read()){

                Aditivo aditivo = new Aditivo();

                aditivo.Id_Aditivo = Convert.ToInt32(dr["Id_Aditivo"].ToString());
                aditivo.FK_Id_Proceso_BP_BJC = Convert.ToInt32(dr["FK_Id_Proceso_BP_BJC"].ToString());
                aditivo.Jugo_Limon = Convert.ToDouble(dr["Jugo_Limon"].ToString());
                aditivo.Ascorbico = Convert.ToDouble(dr["Ascorbico"].ToString());
                aditivo.Citrico = Convert.ToDouble(dr["Citrico"].ToString());
                aditivo.Liquiseb_RL_Concentrado = Convert.ToDouble(dr["Liquiseb_RL_Concentrado"].ToString());
                aditivo.Liquiseb_APL = Convert.ToDouble(dr["Liquiseb_APL"].ToString());
                aditivo.Sebamyl_GL400 = Convert.ToDouble(dr["Sebamyl_GL400"].ToString());
                aditivo.Sebamyl_BAL100 = Convert.ToDouble(dr["Sebamyl_BAL100"].ToString());
                aditivo.Flora_Clair = Convert.ToDouble(dr["Flora_Clair"].ToString());
                aditivo.Gelatina = Convert.ToDouble(dr["Gelatina"].ToString());
                aditivo.Bevasyl = Convert.ToDouble(dr["Bevasyl"].ToString());
                aditivo.Bentonita = Convert.ToDouble(dr["Bentonita"].ToString());
                aditivo.Carbon = Convert.ToDouble(dr["Carbon"].ToString());
                aditivo.Celite = Convert.ToDouble(dr["Celite"].ToString());
                aditivo.HS_4000 = Convert.ToDouble(dr["HS_4000"].ToString());
                aditivo.Shenck_DD = Convert.ToDouble(dr["Shenck_DD"].ToString());
                aditivo.HS_1000 = Convert.ToDouble(dr["HS_1000"].ToString());
                aditivo.HS_1600 = Convert.ToDouble(dr["HS_1600"].ToString());
                aditivo.Estado = dr["Estado"].ToString();
                aditivo.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                aditivo.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                aditivo.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                aditivo.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                lista.Add(aditivo);
            }
            aux.conectar();
            return lista;

        }

    }

}
