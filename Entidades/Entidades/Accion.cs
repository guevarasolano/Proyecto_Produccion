using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Accion{

        public int Id_Accion { get; set; }
        public int FK_Id_Modulo { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public String Estado_Accion { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Accion(int Id_Accion, int FK_Id_Modulo, 
                               String Codigo, String Descripcion,
                               Boolean Estado, String Estado_Accion,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Accion = Id_Accion;
            this.FK_Id_Modulo = FK_Id_Modulo;
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
            this.Estado_Accion = Estado_Accion;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Accion() { }

    }
}
