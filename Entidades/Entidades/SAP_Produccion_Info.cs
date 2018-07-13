using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class SAP_Produccion_Info{

        public int Id_SAP_Produccion_Info { get; set; }
        public int Id_Orden_Fabricacion { get; set; }
        public int Id_Recibo_Produciion { get; set; }
        public int Id_Emision_Produccion { get; set; }
        public String Tipo_Fruta { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public SAP_Produccion_Info(int Id_SAP_Produccion_Info, int Id_Orden_Fabricacion, 
                               int Id_Recibo_Produciion, int Id_Emision_Produccion,
                               String Tipo_Fruta, String Estado,
                               String Usuario_Ingreso,
                               DateTime Fecha_Ingreso, String Usuario_Modificacion,
                               DateTime Fecha_Modificacion){

            this.Id_SAP_Produccion_Info = Id_SAP_Produccion_Info;
            this.Id_Orden_Fabricacion = Id_Orden_Fabricacion;
            this.Id_Recibo_Produciion = Id_Recibo_Produciion;
            this.Id_Emision_Produccion = Id_Emision_Produccion;
            this.Tipo_Fruta = Tipo_Fruta;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public SAP_Produccion_Info() { }

    }
}
