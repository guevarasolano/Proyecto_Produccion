using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Producto_No_Conforme{

        public int Id_Producto_No_Conforme { get; set; }
        public int Id_Articulo_SAP { get; set; }
        public String Lote_Producto { get; set; }
        public int Numero_Unidad { get; set; }
        public double Peso_Toneladas_Metricas { get; set; }
        public String Responsable { get; set; }
        public int Llenadora { get; set; }
        public int Empaque { get; set; }
        public String Tipo_Producto { get; set; }
        public DateTime Fecha_Bloqueo { get; set; }
        public String Area_Bloqueo { get; set; }
        public String Naturaleza_Bloqueo { get; set; }
        public String Hallazgo { get; set; }
        public String Causa { get; set; }
        public String Codigo_Bloqueo { get; set; }
        public String Estado_Unidad { get; set; }
        public String Disposicion_Recomendada { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Producto_No_Conforme(int Id_Producto_No_Conforme, int Id_Articulo_SAP, String Lote_Producto,
                                    int Numero_Unidad, double Peso_Toneladas_Metricas, String Responsable,
                                    int Llenadora, int Empaque, String Tipo_Producto, DateTime Fecha_Bloqueo,
                                    String Area_Bloqueo, String Naturaleza_Bloqueo, String Hallazgo,
                                    String Causa, String Codigo_Bloqueo, String Estado_Unidad, String Disposicion_Recomendada,
                                    String Estado, String Usuario_Ingreso, DateTime Fecha_Ingreso, String Usuario_Modificacion,
                                    DateTime Fecha_Modificacion){

            this.Id_Producto_No_Conforme = Id_Producto_No_Conforme;
            this.Id_Articulo_SAP = Id_Articulo_SAP;
            this.Lote_Producto = Lote_Producto;
            this.Numero_Unidad = Numero_Unidad;
            this.Peso_Toneladas_Metricas = Peso_Toneladas_Metricas;
            this.Responsable = Responsable;
            this.Llenadora = Llenadora;
            this.Empaque = Empaque;
            this.Tipo_Producto = Tipo_Producto;
            this.Fecha_Bloqueo = Fecha_Bloqueo;
            this.Area_Bloqueo = Area_Bloqueo;
            this.Naturaleza_Bloqueo = Naturaleza_Bloqueo;
            this.Hallazgo = Hallazgo;
            this.Causa = Causa;
            this.Codigo_Bloqueo = Codigo_Bloqueo;
            this.Estado_Unidad = Estado_Unidad;
            this.Disposicion_Recomendada = Disposicion_Recomendada;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;

        }

        public Producto_No_Conforme() { }

    }
}
