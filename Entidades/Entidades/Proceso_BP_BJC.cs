using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Proceso_BP_BJC{

        public int Id_Proceso_BP_BJC { get; set; }
        public String Tipo_Producto { get; set; }
        public int Cantidad_Producto_Total { get; set; }
        public Double Porcentaje_Llenado { get; set; }
        public int Cantidad_Cajas_Usadas { get; set; }
        public Double Cantidad_Carga_Banano_Verde_Usado_Kg { get; set; }
        public Double Cantidad_Carga_Banano_Maduro_Usado_Kg { get; set; }
        public int Litros_Producidos { get; set; }
        public int Transferido_Tanque { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Proceso_BP_BJC(int Id_Proceso_BP_BJC,
                               String Tipo_Producto, int Cantidad_Producto_Total,
                               Double Porcentaje_Llenado, int Cantidad_Cajas_Usadas, 
                               Double Cantidad_Carga_Banano_Verde_Usado_Kg,
                               Double Cantidad_Carga_Banano_Maduro_Usado_Kg, int Litros_Producidos,
                               int Transferido_Tanque, String Estado,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Proceso_BP_BJC = Id_Proceso_BP_BJC;
            this.Tipo_Producto = Tipo_Producto;
            this.Cantidad_Producto_Total = Cantidad_Producto_Total;
            this.Porcentaje_Llenado = Porcentaje_Llenado;
            this.Cantidad_Cajas_Usadas = Cantidad_Cajas_Usadas;
            this.Cantidad_Carga_Banano_Verde_Usado_Kg = Cantidad_Carga_Banano_Verde_Usado_Kg;
            this.Cantidad_Carga_Banano_Maduro_Usado_Kg = Cantidad_Carga_Banano_Maduro_Usado_Kg;
            this.Litros_Producidos = Litros_Producidos;
            this.Transferido_Tanque = Transferido_Tanque;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Proceso_BP_BJC() { }

    }
}
