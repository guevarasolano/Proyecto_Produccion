using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace AccesoDatos{

    public class ADPersona {

            //MÉTODO PARA INSERTAR BRIX:
            public Boolean insertarPersona(Persona persona) {

                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.Parameters.Add(new SqlParameter("@Nombre", persona.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Primer_Apellido", persona.Primer_Apellido));
                cmd.Parameters.Add(new SqlParameter("@Segundo_Apellido", persona.Segundo_Apellido));
                cmd.Parameters.Add(new SqlParameter("@Sexo", persona.Sexo));
                cmd.Parameters.Add(new SqlParameter("@Estado", persona.Estado));
                cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", persona.Usuario_Ingreso));
                cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", persona.Fecha_Ingreso));
                cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", persona.Usuario_Modificacion));
                cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", persona.Fecha_Modificacion));
                cmd.CommandText = "InsertarPersona";
                cmd.CommandType = CommandType.StoredProcedure;
                int x = cmd.ExecuteNonQuery();
                aux.conectar();
                if (x >= 1) {
                    return true;
                } else {
                    return false;
                }
            }

            //MÉTODO PARA ACTUALIZAR BRIX:
            public void actualizarPersona(Persona persona) {

                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.Parameters.Add(new SqlParameter("@Id_Persona", persona.Id_Persona));
                cmd.Parameters.Add(new SqlParameter("@Nombre", persona.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Primer_Apellido", persona.Primer_Apellido));
                cmd.Parameters.Add(new SqlParameter("@Segundo_Apellido", persona.Segundo_Apellido));
                cmd.Parameters.Add(new SqlParameter("@Sexo", persona.Sexo));
                cmd.Parameters.Add(new SqlParameter("@Estado", persona.Estado));
                cmd.Parameters.Add(new SqlParameter("@Usuario_Ingreso", persona.Usuario_Ingreso));
                cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", persona.Fecha_Ingreso));
                cmd.Parameters.Add(new SqlParameter("@Usuario_Modificacion", persona.Usuario_Modificacion));
                cmd.Parameters.Add(new SqlParameter("@Fecha_Modificacion", persona.Fecha_Modificacion));
                cmd.CommandText = "ActualizarPersona";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                aux.conectar();
            }

            //MÉTODO PARA ELIMINAR BRIX:
            public Boolean eliminarPersona(int Id_Persona) {

                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.Parameters.Add(new SqlParameter("@Id_Persona", Id_Persona));
                cmd.CommandText = "EliminarPersona";
                cmd.CommandType = CommandType.StoredProcedure;
                int x = cmd.ExecuteNonQuery();
                aux.conectar();
                if (x >= 1) {
                    return true;
                } else {
                    return false;
                }
            }

            //MÉTODO PARA BUSCAR BRIX:
            public Persona buscarPersona(int Id_Persona) {

                Persona persona = new Persona();
                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.Parameters.Add(new SqlParameter("@Id_Persona", Id_Persona));
                cmd.CommandText = "ConsultarPersona";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) {

                persona.Id_Persona = Convert.ToInt32(dr["Id_Persona"].ToString());
                persona.Nombre = dr["Nombre"].ToString();
                persona.Primer_Apellido = dr["Primer_Apellido"].ToString();
                persona.Segundo_Apellido = dr["Segundo_Apellido"].ToString();
                persona.Sexo = dr["Sexo"].ToString();
                persona.Estado = dr["Estado"].ToString();
                persona.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                persona.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                persona.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                persona.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                } else {
                persona = null;
                }
                aux.conectar();
                return persona;
            }

            //MÉTODO PARA LISTAR BRIX:
            public List<Persona> listarPersona() {

                Conexion aux = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = aux.conectar();
                cmd.CommandText = "ListarPersona";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<Persona> lista = new List<Persona>();

                while (dr.Read()) {

                    Persona persona = new Persona();

                persona.Id_Persona = Convert.ToInt32(dr["Id_Persona"].ToString());
                persona.Nombre = dr["Nombre"].ToString();
                persona.Primer_Apellido = dr["Primer_Apellido"].ToString();
                persona.Segundo_Apellido = dr["Segundo_Apellido"].ToString();
                persona.Sexo = dr["Sexo"].ToString();
                persona.Estado = dr["Estado"].ToString();
                persona.Usuario_Ingreso = dr["Usuario_Ingreso"].ToString();
                persona.Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString());
                persona.Usuario_Modificacion = dr["Usuario_Modificacion"].ToString();
                persona.Fecha_Modificacion = Convert.ToDateTime(dr["Fecha_Modificacion"].ToString());

                    lista.Add(persona);
                }
                aux.conectar();
                return lista;

            }

        }

    }

