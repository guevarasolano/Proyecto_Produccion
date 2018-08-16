using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

    public class ADProcesoLlenado{

    public void insertarProcesoLlenado(ProcesoLlenado proceso_Llenado){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_SAP", proceso_Llenado.FK_Id_Articulo_SAP));
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Calidad_SAP", proceso_Llenado.FK_Id_Calidad_SAP));
        cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", proceso_Llenado.Numero_Tanque));
        cmd.Parameters.Add(new SqlParameter("@Numero_Aseptica", proceso_Llenado.Numero_Aseptica));
        cmd.Parameters.Add(new SqlParameter("@Numero_Llenadora", proceso_Llenado.Numero_Llenadora));
        cmd.Parameters.Add(new SqlParameter("@Lote_Proceso", proceso_Llenado.Lote_Proceso));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Llenado", proceso_Llenado.Fecha_Llenado));
        cmd.Parameters.Add(new SqlParameter("@Unidad_Inicial", proceso_Llenado.Unidad_Inicial));
        cmd.Parameters.Add(new SqlParameter("@Unidad_Final", proceso_Llenado.Unidad_Final));
        cmd.Parameters.Add(new SqlParameter("@Cantidad_Muestras", proceso_Llenado.Cantidad_Muestras));
        cmd.Parameters.Add(new SqlParameter("@Cantidad_Bolsas_Mezcla", proceso_Llenado.Cantidad_Bolsas_Mezcla));
        cmd.Parameters.Add(new SqlParameter("@Cantidad_Unidades_Segunda", proceso_Llenado.Cantidad_Unidades_Segunda));
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_Bolsa_SAP", proceso_Llenado.FK_Id_Articulo_Bolsa_SAP));
        cmd.Parameters.Add(new SqlParameter("@Lote_Bolsa", proceso_Llenado.Lote_Bolsa));
        cmd.Parameters.Add(new SqlParameter("@Comentarios", proceso_Llenado.Comentarios));
        cmd.Parameters.Add(new SqlParameter("@Estado", proceso_Llenado.Estado));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_Llenado.Usuario_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_Llenado.Fecha_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_Llenado.Usuario_Modificacion));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_Llenado.Fecha_Modificacion));
        cmd.CommandText = "InsertarProcesoLlenado";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        aux.conectar();
    }

    public void actualizarProcesoLlenado(ProcesoLlenado proceso_Llenado){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", proceso_Llenado.Id_Proceso_Llenado));
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_SAP", proceso_Llenado.FK_Id_Articulo_SAP));
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Calidad_SAP", proceso_Llenado.FK_Id_Calidad_SAP));
        cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", proceso_Llenado.Numero_Tanque));
        cmd.Parameters.Add(new SqlParameter("@Numero_Aseptica", proceso_Llenado.Numero_Aseptica));
        cmd.Parameters.Add(new SqlParameter("@Numero_Llenadora", proceso_Llenado.Numero_Llenadora));
        cmd.Parameters.Add(new SqlParameter("@Lote_Proceso", proceso_Llenado.Lote_Proceso));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Llenado", proceso_Llenado.Fecha_Llenado));
        cmd.Parameters.Add(new SqlParameter("@Unidad_Inicial", proceso_Llenado.Unidad_Inicial));
        cmd.Parameters.Add(new SqlParameter("@Unidad_Final", proceso_Llenado.Unidad_Final));
        cmd.Parameters.Add(new SqlParameter("@Cantidad_Muestras", proceso_Llenado.Cantidad_Muestras));
        cmd.Parameters.Add(new SqlParameter("@Cantidad_Bolsas_Mezcla", proceso_Llenado.Cantidad_Bolsas_Mezcla));
        cmd.Parameters.Add(new SqlParameter("@Cantidad_Unidades_Segunda", proceso_Llenado.Cantidad_Unidades_Segunda));
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_Bolsa_SAP", proceso_Llenado.FK_Id_Articulo_Bolsa_SAP));
        cmd.Parameters.Add(new SqlParameter("@Lote_Bolsa", proceso_Llenado.Lote_Bolsa));
        cmd.Parameters.Add(new SqlParameter("@Comentarios", proceso_Llenado.Comentarios));
        cmd.Parameters.Add(new SqlParameter("@Estado", proceso_Llenado.Estado));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", proceso_Llenado.Usuario_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", proceso_Llenado.Fecha_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", proceso_Llenado.Usuario_Modificacion));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", proceso_Llenado.Fecha_Modificacion));
        cmd.CommandText = "ActualizarProcesoLlenado";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        aux.conectar();
    }

    public void eliminarProcesoLlenado(int Id_Proceso_Llenado){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", Id_Proceso_Llenado));
        cmd.CommandText = "EliminarProcesoLlenado";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        aux.conectar();

    }

    public List<ProcesoLlenado> buscarProcesoLlenado(int Id_Proceso_Llenado){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", Id_Proceso_Llenado));
        cmd.CommandText = "ConsultarProcesoLlenado";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        List<ProcesoLlenado> lista = new List<ProcesoLlenado>();
        ProcesoLlenado procesoLlenado = new ProcesoLlenado();

        while (dr.Read()){

            procesoLlenado.Id_Proceso_Llenado = Convert.ToInt32(dr["Id_Proceso_Llenado"].ToString());
            procesoLlenado.FK_Id_Articulo_SAP = Convert.ToInt32(dr["FK_Id_Articulo_SAP"].ToString());
            procesoLlenado.FK_Id_Calidad_SAP = Convert.ToInt32(dr["FK_Id_Calidad_SAP"].ToString());
            procesoLlenado.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
            procesoLlenado.Numero_Aseptica = Convert.ToInt32(dr["Numero_Aseptica"].ToString());
            procesoLlenado.Numero_Llenadora = Convert.ToInt32(dr["Numero_Llenadora"].ToString());
            procesoLlenado.Lote_Proceso = dr["Lote_Proceso"].ToString();
            procesoLlenado.Fecha_Llenado = Convert.ToDateTime(dr["Fecha_Llenado"].ToString());
            procesoLlenado.Unidad_Inicial = Convert.ToInt32(dr["Unidad_Inicial"].ToString());
            procesoLlenado.Unidad_Final = Convert.ToInt32(dr["Unidad_Final"].ToString());
            procesoLlenado.Cantidad_Muestras = Convert.ToInt32(dr["Cantidad_Muestras"].ToString());
            procesoLlenado.Cantidad_Bolsas_Mezcla = Convert.ToInt32(dr["Cantidad_Bolsas_Mezcla"].ToString());
            procesoLlenado.Cantidad_Unidades_Segunda = Convert.ToInt32(dr["Cantidad_Unidades_Segunda"].ToString());
            procesoLlenado.FK_Id_Articulo_Bolsa_SAP = Convert.ToInt32(dr["FK_Id_Articulo_Bolsa_SAP"].ToString());
            procesoLlenado.Lote_Bolsa = dr["Lote_Bolsa"].ToString();
            procesoLlenado.Comentarios = dr["Comentarios"].ToString();
            procesoLlenado.Estado = dr["Estado"].ToString();
            procesoLlenado.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
            procesoLlenado.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
            procesoLlenado.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
            procesoLlenado.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            lista.Add(procesoLlenado);
        }
        aux.conectar();
        return lista;
    }

    public List<ProcesoLlenado> listar(){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.CommandText = "ListarProcesoLlenado";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        List<ProcesoLlenado> lista = new List<ProcesoLlenado>();

        while (dr.Read()){

            ProcesoLlenado procesoLlenado = new ProcesoLlenado();

            procesoLlenado.Id_Proceso_Llenado = Convert.ToInt32(dr["Id_Proceso_Llenado"].ToString());
            procesoLlenado.FK_Id_Articulo_SAP = Convert.ToInt32(dr["Fk_Id_Articulo_SAP"].ToString());
            procesoLlenado.FK_Id_Calidad_SAP = Convert.ToInt32(dr["Fk_Id_Calidad_SAP"].ToString());
            procesoLlenado.Numero_Tanque = Convert.ToInt32(dr["Numero_Tanque"].ToString());
            procesoLlenado.Numero_Aseptica = Convert.ToInt32(dr["Numero_Aseptica"].ToString());
            procesoLlenado.Numero_Llenadora = Convert.ToInt32(dr["Numero_Llenadora"].ToString());
            procesoLlenado.Lote_Proceso = dr["Lote_Proceso"].ToString();
            procesoLlenado.Fecha_Llenado = Convert.ToDateTime(dr["Fecha_Llenado"].ToString());
            procesoLlenado.Unidad_Inicial = Convert.ToInt32(dr["Unidad_Inicial"].ToString());
            procesoLlenado.Unidad_Final = Convert.ToInt32(dr["Unidad_Final"].ToString());
            procesoLlenado.Cantidad_Muestras = Convert.ToInt32(dr["Cantidad_Muestras"].ToString());
            procesoLlenado.Cantidad_Bolsas_Mezcla = Convert.ToInt32(dr["Cantidad_Bolsas_Mezcla"].ToString());
            procesoLlenado.Cantidad_Unidades_Segunda = Convert.ToInt32(dr["Cantidad_Unidades_Segunda"].ToString());
            procesoLlenado.FK_Id_Articulo_Bolsa_SAP = Convert.ToInt32(dr["Fk_Id_Articulo_Bolsa_SAP"].ToString());
            procesoLlenado.Lote_Bolsa = dr["Lote_Bolsa"].ToString();
            procesoLlenado.Comentarios = dr["Comentarios"].ToString();
            procesoLlenado.Estado = dr["Estado"].ToString();
            procesoLlenado.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
            procesoLlenado.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
            procesoLlenado.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
            procesoLlenado.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            lista.Add(procesoLlenado);
        }
        aux.conectar();
        return lista;

    }

}
