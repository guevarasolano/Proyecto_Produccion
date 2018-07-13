using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Distribucion_Inventario_Tanque{

        public int Id_Distribucion_Inventario_Tanque { get; set; }
        public int Id_Brix;
        public int Numero_Tanque { get; set; }
        public Double Litros { get; set; }
        public Double Kilogramos_Tanque { get; set; }
        public int Estimado_Cantidad_Estañones { get; set; }
        public int Estimado_Cantidad_Bines { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Distribucion_Inventario_Tanque(int Id_Distribucion_Inventario_Tanque, int Id_Brix,
                               int Numero_Tanque, Double Litros,
                               Double Kilogramos_Tanque, int Estimado_Cantidad_Estañones,
                               int Estimado_Cantidad_Bines, String Estado, 
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Distribucion_Inventario_Tanque = Id_Distribucion_Inventario_Tanque;
            this.Id_Brix = Id_Brix;
            this.Numero_Tanque = Numero_Tanque;
            this.Litros = Litros;
            this.Kilogramos_Tanque = Kilogramos_Tanque;
            this.Estimado_Cantidad_Estañones = Estimado_Cantidad_Estañones;
            this.Estimado_Cantidad_Bines = Estimado_Cantidad_Bines;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Distribucion_Inventario_Tanque() { }

    }
}
