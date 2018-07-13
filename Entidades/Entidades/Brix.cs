using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Brix{

        public int Id_Brix { get; set; }
        public Double Bris { get; set; }
        public Double Densidad { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Brix(int Id_Brix, Double Bris, Double Densidad,
                               String Estado, DateTime Fecha_Ultimo_Acceso,
                               String Estado_Accion, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion,
                               DateTime Fecha_Modificacion){

            this.Id_Brix = Id_Brix;
            this.Bris = Bris;
            this.Densidad = Densidad;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Brix() { }

    }
}
