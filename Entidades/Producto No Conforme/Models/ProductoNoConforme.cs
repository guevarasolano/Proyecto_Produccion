using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Producto_No_Conforme.Models{

    public class ProductoNoConforme{

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Producto_No_Conforme { get; set; }

        [Display(Name = "Id Articulo SAP")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public int Id_Articulo_SAP { get; set; }

        [Display(Name = "Lote Producto")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Lote_Producto { get; set; }

        [Display(Name = "Numero Unidad")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Numero_Unidad { get; set; }

        [Display(Name = "Peso Toneladas Metricas")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public Double Peso_Toneladas_Metricas { get; set; }

        [Display(Name = "Responsable")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Responsable { get; set; }

        [Display(Name = "Llenadora")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public int Llenadora { get; set; }

        [Display(Name = "Empaque")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Empaque { get; set; }

        [Display(Name = "Tipo Producto")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Tipo_Producto { get; set; }

        [Display(Name = "Fecha Bloqueo")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha_Bloqueo { get; set; }

        [Display(Name = "Area Bloqueo")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public String Area_Bloqueo { get; set; }

        [Display(Name = "Naturaleza Bloqueo")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public String Naturaleza_Bloqueo { get; set; }

        [Display(Name = "Hallazgo")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Hallazgo { get; set; }

        [Display(Name = "Causa")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Causa { get; set; }

        [Display(Name = "Codigo Bloqueo")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public String Codigo_Bloqueo { get; set; }

        [Display(Name = "Estado Unidad")]
        //[Required(ErrorMessage = "Debe digitar el Usuario Ingreso")]
        public String Estado_Unidad { get; set; }

        [Display(Name = "Disposicion Recomendada")]
        //[Required(ErrorMessage = "Debe digitar la Fecha Ingreso")]
        public String Disposicion_Recomendada { get; set; }

        [Display(Name = "Estado")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public String Estado { get; set; }

        [Display(Name = "Usuario Ingreso")]
        //[Required(ErrorMessage = "Debe digitar el Usuario Ingreso")]
        public String Usuario_Ingreso { get; set; }

        [Display(Name = "Fecha Ingreso")]
        //[Required(ErrorMessage = "Debe digitar la Fecha Ingreso")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha_Ingreso { get; set; }

        [Display(Name = "Usuario Modificación")]
        //[Required(ErrorMessage = "Debe digitar el Usuario Modificación")]
        public String Usuario_Modificacion { get; set; }

        [Display(Name = "Fecha Modificación")]
        //[Required(ErrorMessage = "Debe digitar la Fecha Modificación")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha_Modificacion { get; set; }

    }

}