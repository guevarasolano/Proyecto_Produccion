using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{ 

   public class Rol_Accion{

        public int Id_Rol { get; set; }
        public int Id_Accion { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Rol_Accion(int Id_Rol, int Id_Accion, String Estado,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Rol = Id_Rol;
            this.Id_Accion = Id_Accion;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Rol_Accion() { }

    }
}
