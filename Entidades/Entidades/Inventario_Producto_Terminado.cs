using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Inventario_Producto_Terminado{

        public int Id_Inventario_Producto_Terminado { get; set; }
        public String Tipo_Proceso { get; set; }
        public Double Producto_Inicial { get; set; }
        public Double Producto_Proceso { get; set; }
        public Double Producto_Final { get; set; }
        public DateTime Fecha_Inicial_Periodo { get; set; }
        public DateTime Fecha_Final_Periodo { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Inventario_Producto_Terminado(int Id_Inventario_Producto_Terminado,
                               String Tipo_Proceso, Double Producto_Inicial,
                               Double Producto_Proceso, Double Producto_Final, 
                               DateTime Fecha_Inicial_Periodo, DateTime Fecha_Final_Periodo, 
                               String Estado, String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Inventario_Producto_Terminado = Id_Inventario_Producto_Terminado;
            this.Tipo_Proceso = Tipo_Proceso;
            this.Producto_Inicial = Producto_Inicial;
            this.Producto_Proceso = Producto_Proceso;
            this.Producto_Final = Producto_Final;
            this.Fecha_Inicial_Periodo = Fecha_Inicial_Periodo;
            this.Fecha_Final_Periodo = Fecha_Final_Periodo;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Inventario_Producto_Terminado() { }

    }
}
