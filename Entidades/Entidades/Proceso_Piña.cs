using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    class Proceso_Piña{

        private int FK_Id_Proceso_Llenado { get; set; }
        private int FK_Id_Proceso_Ingreso_Piña { get; set; }
        private String Fecha_Llenado { get; set; }
        private int Cantidad_Producto_Total { get; set; }
        private Double Procentaje_Llenado { get; set; }
        private Double Brix_Entrada { get; set; }
        private Double Brix_Salida { get; set; }
        private Double Porcentaje_Rendimiento { get; set; }
        private String Tipo_Producto { get; set; }
        private String Estado { get; set; }
        private String Usuario_Ingreso { get; set; }
        private String Fecha_Ingreso { get; set; }
        private String Usuario_Modificacion { get; set; }
        private String Fecha_Modificacion { get; set; }

        public Proceso_Piña(int FK_Id_Proceso_Llenado, int FK_Id_Proceso_Ingreso_Piña,
                               String Fecha_Llenado, int Cantidad_Producto_Total, Double Procentaje_Llenado,
                               Double Brix_Entrada, Double Brix_Salida, Double Porcentaje_Rendimiento,
                               String Tipo_Producto, String Estado, String Usuario_Ingreso,
                               String Fecha_Ingreso, String Usuario_Modificacion, String Fecha_Modificacion){

            this.FK_Id_Proceso_Llenado = FK_Id_Proceso_Llenado;
            this.FK_Id_Proceso_Ingreso_Piña = FK_Id_Proceso_Ingreso_Piña;
            this.Fecha_Llenado = Fecha_Llenado;
            this.Cantidad_Producto_Total = Cantidad_Producto_Total;
            this.Procentaje_Llenado = Procentaje_Llenado;
            this.Brix_Entrada = Brix_Entrada;
            this.Brix_Salida = Brix_Salida;
            this.Porcentaje_Rendimiento = Porcentaje_Rendimiento;
            this.Tipo_Producto = Tipo_Producto;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;

        }
    }
}
