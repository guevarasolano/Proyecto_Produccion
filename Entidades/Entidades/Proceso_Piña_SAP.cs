using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Proceso_Piña_SAP{

        public int Id_Proceso_Llenado { get; set; }
        public int Id_Proceso_Ingreso_Piña { get; set; }
        public int Id_SAP_Produccion_Info { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Proceso_Piña_SAP(int Id_Proceso_Llenado, int Id_Proceso_Ingreso_Piña,
                               int Id_SAP_Produccion_Info, String Estado, String Usuario_Ingreso,
                               DateTime Fecha_Ingreso, String Usuario_Modificacion,
                               DateTime Fecha_Modificacion){

            this.Id_Proceso_Llenado = Id_Proceso_Llenado;
            this.Id_Proceso_Ingreso_Piña = Id_Proceso_Ingreso_Piña;
            this.Id_SAP_Produccion_Info = Id_SAP_Produccion_Info;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Proceso_Piña_SAP() { }

    }
}
