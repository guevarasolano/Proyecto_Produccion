using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapaEntidades{

    public class InventarioProductoTerminado{

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Inventario_Producto_Terminado { get; set; }

        [Display(Name = "Tipo Proceso")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Tipo_Proceso { get; set; }

        [Display(Name = "Producto Inicial")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public Double Producto_Inicial { get; set; }

        [Display(Name = "Producto Proceso")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public Double Producto_Proceso { get; set; }

        [Display(Name = "Producto Final")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public Double Producto_Final { get; set; }    

        [Display(Name = "Fecha Inicial Periodo")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public DateTime Fecha_Inicial_Periodo { get; set; }

        [Display(Name = "Fecha Final Periodo")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public DateTime Fecha_Final_Periodo { get; set; }

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