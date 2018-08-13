using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAP_Produccion_Info.Models{

    public class SAPProduccionInfo{

        [Display(Name = "Id")]
        public int Id_SAP_Produccion_Info { get; set; }

        [Display(Name = "Id Orden Fabricacion")]
        public int Id_Orden_Fabricacion { get; set; }

        [Display(Name = "Id Recibo Producccion")]
        public int Id_Recibo_Produccion { get; set; }

        [Display(Name = "Id Emision Produccion")]
        public int Id_Emision_Produccion { get; set; }

        [Display(Name = "Tipo Fruta")]
        public String Tipo_Fruta { get; set; }

        [Display(Name = "Estado")]
        public String Estado { get; set; }

        [Display(Name = "Usuario Ingreso")]
        public String Usuario_Ingreso { get; set; }

        [Display(Name = "Fecha Ingreso")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha_Ingreso { get; set; }

        [Display(Name = "Usuario Modificación")]
        public String Usuario_Modificacion { get; set; }

        [Display(Name = "Fecha Modificación")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha_Modificacion { get; set; }

    }
}