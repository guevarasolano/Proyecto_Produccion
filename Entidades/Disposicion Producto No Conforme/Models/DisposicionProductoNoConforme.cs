using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Disposicion_Producto_No_Conforme.Models{

    public class DisposicionProductoNoConforme{

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Disposicion_Producto_No_Conforme { get; set; }

        [Display(Name = "Id Producto No Conforme")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public int FK_Id_Producto_No_Conforme { get; set; }

        [Display(Name = "Fecha Disposicion")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public DateTime Fecha_Disposicion { get; set; }

        [Display(Name = "Disposicion_Final")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public String Disposicion_Final { get; set; }

        [Display(Name = "Tanque Destino")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public int Tanque_Destino { get; set; }

        [Display(Name = "Se Dispone")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public String Se_Dispone { get; set; }

        [Display(Name = "Disposicion Empaque")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public String Disposicion_Empaque { get; set; }

        [Display(Name = "Lote Reproceso Producto")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Lote_Reproceso_Producto { get; set; }

        [Display(Name = "Observaciones")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Observaciones { get; set; }

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