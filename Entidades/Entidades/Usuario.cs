using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Usuario{

        public int Id_Usuario { get; set; }
        public String Dominio { get; set; }
        public String Nombre_Usuario { get; set; }
        public String Nombre_Completo { get; set; }
        public String Primer_Apellido { get; set; }
        public String Segundo_Apellido { get; set; }
        public String Correo_Electronico { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Fecha_Ultimo_Acceso { get; set; }
        public String Estado_Accion { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Usuario(int Id_Usuario, String Dominio, String Nombre_Usuario,
                               String Nombre_Completo, String Primer_Apellido,
                               String Segundo_Apellido, String Correo_Electronico,
                               Boolean Estado, DateTime Fecha_Ultimo_Acceso, 
                               String Estado_Accion, DateTime Fecha_Ingreso, 
                               String Usuario_Modificacion, 
                               DateTime Fecha_Modificacion){

            this.Id_Usuario = Id_Usuario;
            this.Dominio = Dominio;
            this.Nombre_Usuario = Nombre_Usuario;
            this.Nombre_Completo = Nombre_Completo;
            this.Primer_Apellido = Primer_Apellido;
            this.Segundo_Apellido = Segundo_Apellido;
            this.Correo_Electronico = Correo_Electronico;
            this.Estado = Estado;
            this.Fecha_Ultimo_Acceso = Fecha_Ultimo_Acceso;
            this.Estado_Accion = Estado_Accion;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Usuario() { }

    }
}
