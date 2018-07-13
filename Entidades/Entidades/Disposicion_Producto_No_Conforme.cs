using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{

    public class Disposicion_Producto_No_Conforme{

        public int Id_Disposicion_Producto_No_Conforme { get; set; }
        public int Id_Producto_No_Conforme { get; set; }
        public DateTime Fecha_Disposicion { get; set; }
        public String Disposicion_Final { get; set; }
        public int Tanque_Destino { get; set; }
        public String Se_Dispone { get; set; }
        public String Disposicion_Empaque { get; set; }
        public String Lote_Reproceso_Producto { get; set; }
        public String Observaciones { get; set; }
        public String Estado { get; set; }
        public String Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public String Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Disposicion_Producto_No_Conforme(int Id_Disposicion_Producto_No_Conforme, 
                               int Id_Producto_No_Conforme, DateTime Fecha_Disposicion,
                               String Disposicion_Final, int Tanque_Destino, String Se_Dispone,
                               String Disposicion_Empaque, String Lote_Reproceso_Producto,
                               String Observaciones, String Estado,
                               String Usuario_Ingreso, DateTime Fecha_Ingreso,
                               String Usuario_Modificacion, DateTime Fecha_Modificacion){

            this.Id_Disposicion_Producto_No_Conforme = Id_Disposicion_Producto_No_Conforme;
            this.Id_Producto_No_Conforme = Id_Producto_No_Conforme;
            this.Fecha_Disposicion = Fecha_Disposicion;
            this.Disposicion_Final = Disposicion_Final;
            this.Tanque_Destino = Tanque_Destino;
            this.Se_Dispone = Se_Dispone;
            this.Disposicion_Empaque = Disposicion_Empaque;
            this.Lote_Reproceso_Producto = Lote_Reproceso_Producto;
            this.Observaciones = Observaciones;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

        public Disposicion_Producto_No_Conforme() { }

    }
}
