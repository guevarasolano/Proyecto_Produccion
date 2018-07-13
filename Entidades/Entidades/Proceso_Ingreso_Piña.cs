using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Proceso_Ingreso_Piña{

        public int Id_Proceso_Ingreso_Piña { get; set; }
        public int Numero_Recibo { get; set; }
        public String Numero_Carga { get; set; }
        public Double Cantidad_Piña_Utilizada_Kg { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Proceso_Ingreso_Piña(int Id_Proceso_Ingreso_Piña, int Numero_Recibo, String Numero_Carga,
                               Double Cantidad_Piña_Utilizada_Kg, String Estado,
                               DateTime Fecha_Ingreso, String Usuario_Modificacion,
                               DateTime Fecha_Modificacion){

            this.Id_Proceso_Ingreso_Piña = Id_Proceso_Ingreso_Piña;
            this.Numero_Recibo = Numero_Recibo;
            this.Numero_Carga = Numero_Carga;
            this.Cantidad_Piña_Utilizada_Kg = Cantidad_Piña_Utilizada_Kg;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Proceso_Ingreso_Piña() { }

    }
}
