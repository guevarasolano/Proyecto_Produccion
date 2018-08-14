﻿using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

    public class ADAccion{

    public Boolean insertarAccion(Accion.Models.Accion accion){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Modulo", accion.FK_Id_Modulo));
        cmd.Parameters.Add(new SqlParameter("@Codigo", accion.Codigo));
        cmd.Parameters.Add(new SqlParameter("@Descripcion", accion.Descripcion));
        cmd.Parameters.Add(new SqlParameter("@Estado", accion.Estado));
        cmd.Parameters.Add(new SqlParameter("@Estado_Accion", accion.Estado_Accion));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", accion.Usuario_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", accion.Fecha_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", accion.Usuario_Modificacion));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", accion.Fecha_Modificacion));
        cmd.CommandText = "InsertarAccion";
        cmd.CommandType = CommandType.StoredProcedure;
        int x = cmd.ExecuteNonQuery();
        aux.conectar();
        if (x >= 1){
            return true;
        }else{
            return false;
        }
    }

    public void actualizarAccion(Accion.Models.Accion accion){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@Id_Accion", accion.Id_Accion));
        cmd.Parameters.Add(new SqlParameter("@FK_Id_Modulo", accion.FK_Id_Modulo));
        cmd.Parameters.Add(new SqlParameter("@Codigo", accion.Codigo));
        cmd.Parameters.Add(new SqlParameter("@Controlador", accion.Descripcion));
        cmd.Parameters.Add(new SqlParameter("@Descripcion", accion.Estado));
        cmd.Parameters.Add(new SqlParameter("@Estado_Accion", accion.Estado_Accion));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", accion.Usuario_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", accion.Fecha_Ingreso));
        cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", accion.Usuario_Modificacion));
        cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", accion.Fecha_Modificacion));
        cmd.CommandText = "ActualizarAccion";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        aux.conectar();
    }

    public bool eliminarAccion(int Id_Accion){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@Id_Accion", Id_Accion));
        cmd.CommandText = "EliminarAccion";
        cmd.CommandType = CommandType.StoredProcedure;
        int x = cmd.ExecuteNonQuery();
        aux.conectar();
        if (x >= 1){
            return true;
        }else{
            return false;
        }
    }

    public Accion.Models.Accion buscarAccion(int Id_Accion){

        Accion.Models.Accion accion = new Accion.Models.Accion();
        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.Parameters.Add(new SqlParameter("@Id_Accion", Id_Accion));
        cmd.CommandText = "ConsultarAccion";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read()){

            accion.Id_Accion = Convert.ToInt32(dr["Id_Accion"].ToString());
            accion.FK_Id_Modulo = Convert.ToInt32(dr["FK_Id_Modulo"].ToString());
            accion.Codigo = dr["Codigo"].ToString();
            accion.Descripcion = dr["Descripcion"].ToString();
            accion.Estado = Convert.ToBoolean(dr["Estado"].ToString());
            accion.Estado_Accion = dr["Estado_Accion"].ToString();
            accion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
            accion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
            accion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
            accion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

        }else{
            accion = null;
        }
        aux.conectar();
        return accion;
    }

    public List<Accion.Models.Accion> listarAccion(){

        Conexion aux = new Conexion();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = aux.conectar();
        cmd.CommandText = "ListarAccion";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        List<Accion.Models.Accion> lista = new List<Accion.Models.Accion>();

        while (dr.Read()){

            Accion.Models.Accion accion = new Accion.Models.Accion();

            accion.Id_Accion = Convert.ToInt32(dr["Id_Accion"].ToString());
            accion.FK_Id_Modulo = Convert.ToInt32(dr["FK_Id_Modulo"].ToString());
            accion.Codigo = dr["Codigo"].ToString();
            accion.Descripcion = dr["Descripcion"].ToString();
            accion.Estado = Convert.ToBoolean(dr["Estado"].ToString());
            accion.Estado_Accion = dr["Estado_Accion"].ToString();
            accion.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
            accion.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
            accion.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
            accion.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

            lista.Add(accion);
        }
        aux.conectar();
        return lista;
    }

}
