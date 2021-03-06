﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Prueba{

    public class ADInventarioProductoTerminado{

        public void insertarInventarioProductoTerminado(Inventario_Producto_Terminado inventario_Producto_Terminado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Tipo_Proceso", inventario_Producto_Terminado.Tipo_Proceso));
            cmd.Parameters.Add(new SqlParameter("@Producto_Inicial", inventario_Producto_Terminado.Producto_Inicial));
            cmd.Parameters.Add(new SqlParameter("@Producto_Proceso", inventario_Producto_Terminado.Producto_Proceso));
            cmd.Parameters.Add(new SqlParameter("@Producto_Final", inventario_Producto_Terminado.Producto_Final));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Inicial_Periodo", inventario_Producto_Terminado.Fecha_Inicial_Periodo));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Final_Periodo", inventario_Producto_Terminado.Fecha_Final_Periodo));
            cmd.Parameters.Add(new SqlParameter("@Estado", inventario_Producto_Terminado.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", inventario_Producto_Terminado.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", inventario_Producto_Terminado.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", inventario_Producto_Terminado.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", inventario_Producto_Terminado.Fecha_Modificacion));
            cmd.CommandText = "InsertarInventarioProductoTerminado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void actualizarInventarioProductoTerminado(Inventario_Producto_Terminado inventario_Producto_Terminado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Inventario_Producto_Terminado", inventario_Producto_Terminado.Id_Inventario_Producto_Terminado));
            cmd.Parameters.Add(new SqlParameter("@Tipo_Proceso", inventario_Producto_Terminado.Tipo_Proceso));
            cmd.Parameters.Add(new SqlParameter("@Producto_Inicial", inventario_Producto_Terminado.Producto_Inicial));
            cmd.Parameters.Add(new SqlParameter("@Producto_Proceso", inventario_Producto_Terminado.Producto_Proceso));
            cmd.Parameters.Add(new SqlParameter("@Producto_Final", inventario_Producto_Terminado.Producto_Final));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Inicial_Periodo", inventario_Producto_Terminado.Fecha_Inicial_Periodo));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Final_Periodo", inventario_Producto_Terminado.Fecha_Final_Periodo));
            cmd.Parameters.Add(new SqlParameter("@Estado", inventario_Producto_Terminado.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", inventario_Producto_Terminado.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", inventario_Producto_Terminado.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", inventario_Producto_Terminado.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", inventario_Producto_Terminado.Fecha_Modificacion));
            cmd.CommandText = "ActualizarInventarioProductoTerminado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
        }

        public void eliminarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Inventario_Producto_Terminado", Id_Inventario_Producto_Terminado));
            cmd.CommandText = "EliminarInventarioProductoTerminado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();

        }

        public List<Inventario_Producto_Terminado> buscarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Inventario_Producto_Terminado", Id_Inventario_Producto_Terminado));
            cmd.CommandText = "ConsultarInventarioProductoTerminado";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Inventario_Producto_Terminado> lista = new List<Inventario_Producto_Terminado>();
            Inventario_Producto_Terminado inventarioProductoTerminado = new Inventario_Producto_Terminado();

            while (dr.Read()){

                inventarioProductoTerminado.Id_Inventario_Producto_Terminado = Convert.ToInt32(dr["Id_Inventario_Producto_Terminado"].ToString());
                inventarioProductoTerminado.Tipo_Proceso = dr["Tipo_Proceso"].ToString();
                inventarioProductoTerminado.Producto_Inicial = Convert.ToDouble(dr["Producto_Inicial"].ToString());
                inventarioProductoTerminado.Producto_Proceso = Convert.ToDouble(dr["Producto_Proceso"].ToString());
                inventarioProductoTerminado.Producto_Final = Convert.ToDouble(dr["Producto_Final"].ToString());
                inventarioProductoTerminado.Fecha_Inicial_Periodo = Convert.ToDateTime(dr["Fecha_Inicial_Periodo"].ToString());
                inventarioProductoTerminado.Fecha_Final_Periodo = Convert.ToDateTime(dr["Fecha_Final_Periodo"].ToString());
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

        public List<Inventario_Producto_Terminado> listarInventarioProductoTerminado(){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "ListarInventarioProductoTerminado";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Inventario_Producto_Terminado> lista = new List<Inventario_Producto_Terminado>();

            while (dr.Read()){

                Inventario_Producto_Terminado inventarioProductoTerminado = new Inventario_Producto_Terminado();

                inventarioProductoTerminado.Id_Inventario_Producto_Terminado = Convert.ToInt32(dr["Id_Inventario_Producto_Terminado"].ToString());
                inventarioProductoTerminado.Tipo_Proceso = dr["Tipo_Proceso"].ToString();
                inventarioProductoTerminado.Producto_Inicial = Convert.ToDouble(dr["Producto_Inicial"].ToString());
                inventarioProductoTerminado.Producto_Proceso = Convert.ToDouble(dr["Producto_Proceso"].ToString());
                inventarioProductoTerminado.Producto_Final = Convert.ToDouble(dr["Producto_Final"].ToString());
                inventarioProductoTerminado.Fecha_Inicial_Periodo = Convert.ToDateTime(dr["Fecha_Inicial_Periodo"].ToString());
                inventarioProductoTerminado.Fecha_Final_Periodo = Convert.ToDateTime(dr["Fecha_Final_Periodo"].ToString());
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
