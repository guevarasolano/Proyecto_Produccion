using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Proceso_Maduracion{

        public int Id_Proceso_Maduracion { get; set; }
        public int Numero_Recibo { get; set; }
        public String Numero_Carga { get; set; }
        public DateTime Fecha_Entrada_Camara { get; set; }
        public Double Cantidad_Banano_Ingreso_Kg { get; set; }
        public Double Cantidad_Banano_Maduro_Kg { get; set; }
        public int Total_Cajas { get; set; }
        public int Total_Cajas_Bloqueadas { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Proceso_Maduracion(int Id_Proceso_Maduracion, int Numero_Recibo,
                               String Numero_Carga, DateTime Fecha_Entrada_Camara,
                               Double Cantidad_Banano_Ingreso_Kg, Double Cantidad_Banano_Maduro_Kg,
                               int Total_Cajas, int Total_Cajas_Bloqueadas, String Estado,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Proceso_Maduracion = Id_Proceso_Maduracion;
            this.Numero_Recibo = Numero_Recibo;
            this.Numero_Carga = Numero_Carga;
            this.Fecha_Entrada_Camara = Fecha_Entrada_Camara;
            this.Cantidad_Banano_Ingreso_Kg = Cantidad_Banano_Ingreso_Kg;
            this.Cantidad_Banano_Maduro_Kg = Cantidad_Banano_Maduro_Kg;
            this.Total_Cajas = Total_Cajas;
            this.Total_Cajas_Bloqueadas = Total_Cajas_Bloqueadas;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Proceso_Maduracion () { }

    }
}
