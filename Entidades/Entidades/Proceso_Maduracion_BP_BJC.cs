using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{


    public class Proceso_Maduracion_BP_BJC{

        public int Id_Proceso_Maduracion { get; set; }
        public int Id_Proceso_BP_BJC { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Proceso_Maduracion_BP_BJC(int Id_Proceso_Maduracion, int Id_Proceso_BP_BJC, 
                               String Estado, String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Proceso_Maduracion = Id_Proceso_Maduracion;
            this.Id_Proceso_BP_BJC = Id_Proceso_BP_BJC;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Proceso_Maduracion_BP_BJC() { }

    }
}
