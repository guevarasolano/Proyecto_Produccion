using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Aplicacion{

        public int Id_Aplicacion { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public String Controlador { get; set; }
        public Boolean Estado { get; set; }
        public String Estado_Accion { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Aplicacion(int Id_Aplicacion, String Codigo,
                               String Descripcion, String Controlador,
                               Boolean Estado, String Estado_Accion,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Aplicacion = Id_Aplicacion;
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Controlador = Controlador;
            this.Estado = Estado;
            this.Estado_Accion = Estado_Accion;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Aplicacion() { }

    }
}
