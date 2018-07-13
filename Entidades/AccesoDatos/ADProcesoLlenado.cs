using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AccesoDatos{

    class ADProcesoLlenado {

        public void insertarProcesoLlenado(Proceso_Llenado procesoLlenado) {

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", procesoLlenado.Id_Proceso_Llenado));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_SAP", procesoLlenado.FK_Id_Articulo_SAP));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Calidad_SAP", procesoLlenado.FK_Id_Calidad_SAP));
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", procesoLlenado.Numero_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Numero_Aseptica", procesoLlenadoNumero_Aseptica));
            cmd.Parameters.Add(new SqlParameter("@Numero_Llenadora", procesoLlenado.Numero_Llenadora));
            cmd.Parameters.Add(new SqlParameter("@Lote_Proceso", procesoLlenado.Lote_Proceso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Llenado", procesoLlenado.Fecha_Llenado));
            cmd.Parameters.Add(new SqlParameter("@Unidad_Inicial", procesoLlenado.Unidad_Inicial));
            cmd.Parameters.Add(new SqlParameter("@Unidad_Final", procesoLlenado.Unidad_Final));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Muestras", procesoLlenado.Cantidad_Muestras));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Bolsas_Muestra", procesoLlenado.Cantidad_Bolsas_Muestra));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Unidades_Segunda", procesoLlenado.Cantidad_Unidades_Segunda));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_Bolsa_SAP", procesoLlenado.FK_Id_Articulo_Bolsa_SAP));
            cmd.Parameters.Add(new SqlParameter("@Lote_Bolsa", procesoLlenado.Lote_Bolsa));
            cmd.Parameters.Add(new SqlParameter("@Comentarios", procesoLlenado.Comentarios));
            cmd.Parameters.Add(new SqlParameter("@Estado", procesoLlenado.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", procesoLlenado.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", procesoLlenado.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", procesoLlenado.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", procesoLlenado.Fecha_Modificacion));
            cmd.CommandText = "InsertarProcesoLlenado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.executeNonQuery();
            aux.conectar();
        }

        public void actualizarProcesoLlenado(Entidades.Proceso_Llenado procesoLlenado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", procesoLlenado.Id_Proceso_Llenado));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_SAP", procesoLlenado.FK_Id_Articulo_SAP));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Calidad_SAP", procesoLlenado.FK_Id_Calidad_SAP));
            cmd.Parameters.Add(new SqlParameter("@Numero_Tanque", procesoLlenado.Numero_Tanque));
            cmd.Parameters.Add(new SqlParameter("@Numero_Aseptica", procesoLlenadoNumero_Aseptica));
            cmd.Parameters.Add(new SqlParameter("@Numero_Llenadora", procesoLlenado.Numero_Llenadora));
            cmd.Parameters.Add(new SqlParameter("@Lote_Proceso", procesoLlenado.Lote_Proceso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Llenado", procesoLlenado.Fecha_Llenado));
            cmd.Parameters.Add(new SqlParameter("@Unidad_Inicial", procesoLlenado.Unidad_Inicial));
            cmd.Parameters.Add(new SqlParameter("@Unidad_Final", procesoLlenado.Unidad_Final));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Muestras", procesoLlenado.Cantidad_Muestras));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Bolsas_Muestra", procesoLlenado.Cantidad_Bolsas_Muestra));
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Unidades_Segunda", procesoLlenado.Cantidad_Unidades_Segunda));
            cmd.Parameters.Add(new SqlParameter("@FK_Id_Articulo_Bolsa_SAP", procesoLlenado.FK_Id_Articulo_Bolsa_SAP));
            cmd.Parameters.Add(new SqlParameter("@Lote_Bolsa", procesoLlenado.Lote_Bolsa));
            cmd.Parameters.Add(new SqlParameter("@Comentarios", procesoLlenado.Comentarios));
            cmd.Parameters.Add(new SqlParameter("@Estado", procesoLlenado.Estado));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", procesoLlenado.Usuario_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", procesoLlenado.Fecha_Ingreso));
            cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", procesoLlenado.Usuario_Modificacion));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", procesoLlenado.Fecha_Modificacion));
            cmd.CommandText = "ActualizarProcesoLlenado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.executeNonQuery();
            aux.conectar();
        }

        public void eliminarProcesoLlenado(String Id_Proceso_Llenado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", Id_Proceso_Llenado));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.executeNonQuery();
            aux.conectar();

        }

        public List<Entidades.ProcesoLlenado> buscarProcesoLlenado(String Id_Proceso_Llenado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", Id_Proceso_Llenado));
            cmd.CommandText= "ConsultarProcesoLlenado";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.executeReader();
            List<Entidades.ProcesoLlenado> lista = new List<Entidades.ProcesoLlenado>();
            Entidades.Proceso_Llenado procesoLlenado = new Entidades.Proceso_Llenado();

            while (dr.Read()) {

                procesoLlenado.Id_Proceso_Llenado = dr["Id_Proceso_Llenado"].toString();
                procesoLlenado.FK_Id_Articulo_SAP = dr["FK_Id_Articulo_SAP"].toString();
                procesoLlenado.FK_Id_Calidad_SAP = dr["FK_Id_Calidad_SAP"].toString();
                procesoLlenado.Numero_Tanque = dr["Numero_Tanque"].toString();
                procesoLlenado.Numero_Aseptica = dr["Numero_Aseptica"].toString();
                procesoLlenado.Numero_Llenadora = dr["Numero_Llenadora"].toString();
                procesoLlenado.Lote_Proceso = dr["Lote_Proceso"].toString();
                procesoLlenado.Fecha_Llenado = dr["Fecha_Llenado"].toString();
                procesoLlenado.Unidad_Inicial = dr["Unidad_Inicial"].toString();
                procesoLlenado.Unidad_Final = dr["Unidad_Final"].toString();
                procesoLlenado.Cantidad_Muestras = dr["Cantidad_Muestras"].toString();
                procesoLlenado.Cantidad_Bolsas_Mezcla = dr["Cantidad_Bolsas_Mezcla"].toString();
                procesoLlenado.Cantidad_Unidades_Segunda = dr["Cantidad_Unidades_Segunda"].toString();
                procesoLlenado.FK_Id_Articulo_Bolsa_SAP = dr["FK_Id_Articulo_Bolsa_SAP"].toString();
                procesoLlenado.Lote_Bolsa = dr["Lote_Bolsa"].toString();
                procesoLlenado.Comentarios = dr["Comentarios"].toString();
                procesoLlenado.Estado = dr["Estado"].toString();
                procesoLlenado.Usuario_Ingreso = dr["Usuario_Ingreso"].toString();
                procesoLlenado.Fecha_Ingreso = dr["Fecha_Ingreso"].toString();
                procesoLlenado.Usuario_Modificacion = dr["Usuario_Modificacion"].toString();
                procesoLlenado.Fecha_Modificacion = dr["Fecha_Modificacion"].toString();

                lista.Add(procesoLlenado);
            }
            aux.conectar();
            return lista;
        }

        public List<Entidades.ProcesoLlenado> listar(String Id_Proceso_Llenado){

            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.Parameters.Add(new SqlParameter("@Id_Proceso_Llenado", Id_Proceso_Llenado));
            cmd.CommandText = "ConsultarProcesoLlenado";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.executeReader();
            List<Entidades.ProcesoLlenado> lista = new List<Entidades.ProcesoLlenado>();
            Entidades.Proceso_Llenado procesoLlenado = new Entidades.Proceso_Llenado();

            while (dr.Read())
            {

                procesoLlenado.Id_Proceso_Llenado = dr["Id_Proceso_Llenado"].toString();
                procesoLlenado.FK_Id_Articulo_SAP = dr["FK_Id_Articulo_SAP"].toString();
                procesoLlenado.FK_Id_Calidad_SAP = dr["FK_Id_Calidad_SAP"].toString();
                procesoLlenado.Numero_Tanque = dr["Numero_Tanque"].toString();
                procesoLlenado.Numero_Aseptica = dr["Numero_Aseptica"].toString();
                procesoLlenado.Numero_Llenadora = dr["Numero_Llenadora"].toString();
                procesoLlenado.Lote_Proceso = dr["Lote_Proceso"].toString();
                procesoLlenado.Fecha_Llenado = dr["Fecha_Llenado"].toString();
                procesoLlenado.Unidad_Inicial = dr["Unidad_Inicial"].toString();
                procesoLlenado.Unidad_Final = dr["Unidad_Final"].toString();
                procesoLlenado.Cantidad_Muestras = dr["Cantidad_Muestras"].toString();
                procesoLlenado.Cantidad_Bolsas_Mezcla = dr["Cantidad_Bolsas_Mezcla"].toString();
                procesoLlenado.Cantidad_Unidades_Segunda = dr["Cantidad_Unidades_Segunda"].toString();
                procesoLlenado.FK_Id_Articulo_Bolsa_SAP = dr["FK_Id_Articulo_Bolsa_SAP"].toString();
                procesoLlenado.Lote_Bolsa = dr["Lote_Bolsa"].toString();
                procesoLlenado.Comentarios = dr["Comentarios"].toString();
                procesoLlenado.Estado = dr["Estado"].toString();
                procesoLlenado.Usuario_Ingreso = dr["Usuario_Ingreso"].toString();
                procesoLlenado.Fecha_Ingreso = dr["Fecha_Ingreso"].toString();
                procesoLlenado.Usuario_Modificacion = dr["Usuario_Modificacion"].toString();
                procesoLlenado.Fecha_Modificacion = dr["Fecha_Modificacion"].toString();

                lista.Add(procesoLlenado);
            }
            aux.conectar();
            return lista;

        }

    }

    }

