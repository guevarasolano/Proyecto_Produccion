using System;

namespace Entidades{

    public class Proceso_Llenado{

        public int Id_Proceso_Llenado { get; set; }
        public int Id_Articulo_SAP { get; set; }
        public int Id_Calidad_SAP { get; set; }
        public int Numero_Tanque { get; set; }
        public int Numero_Aseptica { get; set; }
        public int Numero_Llenadora { get; set; }
        public String Lote_Proceso { get; set; }
        public DateTime Fecha_Llenado { get; set; }
        public int Unidad_Inicial { get; set; }
        public int Unidad_Final { get; set; }
        public int Cantidad_Muestras { get; set; }
        public int Cantidad_Bolsas_Mezcla { get; set; }
        public int Cantidad_Unidades_Segunda { get; set; }
        public int Id_Articulo_Bolsa_SAP { get; set; }
        public String Lote_Bolsa { get; set; }
        public String Comentarios { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Proceso_Llenado(int Id_Proceso_Llenado, int Id_Articulo_SAP, int Id_Calidad_SAP,
                               int Numero_Tanque, int Numero_Aseptica, int Numero_Llenadora,
                               String Lote_Proceso, DateTime Fecha_Llenado, int Unidad_Inicial,
                               int Unidad_Final, int Cantidad_Muestras, int Cantidad_Bolsas_Mezcla,
                               int Cantidad_Unidades_Segunda, int Id_Articulo_Bolsa_SAP,
                               String Lote_Bolsa, String Comentarios, String Estado,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Proceso_Llenado = Id_Proceso_Llenado;
            this.Id_Articulo_SAP = Id_Articulo_SAP;
            this.Id_Calidad_SAP = Id_Calidad_SAP;
            this.Numero_Tanque = Numero_Tanque;
            this.Numero_Aseptica = Numero_Aseptica;
            this.Numero_Llenadora = Numero_Llenadora;
            this.Lote_Proceso = Lote_Proceso;
            this.Fecha_Llenado = Fecha_Llenado;
            this.Unidad_Inicial = Unidad_Inicial;
            this.Unidad_Final = Unidad_Final;
            this.Cantidad_Muestras = Cantidad_Muestras;
            this.Cantidad_Bolsas_Mezcla = Cantidad_Bolsas_Mezcla;
            this.Cantidad_Unidades_Segunda = Cantidad_Unidades_Segunda;
            this.Id_Articulo_Bolsa_SAP = Id_Articulo_Bolsa_SAP;
            this.Lote_Bolsa = Lote_Bolsa;
            this.Comentarios = Comentarios;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Proceso_Llenado() { }

    }
}