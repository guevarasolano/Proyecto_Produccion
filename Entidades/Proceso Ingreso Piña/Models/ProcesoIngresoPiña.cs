using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proceso_Ingreso_Piña.Models{

    public class ProcesoIngresoPiña{

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Proceso_Ingreso_Piña { get; set; }

        [Display(Name = "Numero Recibo")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public int Numero_Recibo { get; set; }

        [Display(Name = "Numero Carga")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Numero_Carga { get; set; }

        [Display(Name = "Cantidad Piña Utilizada Kg")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public Double Cantidad_Piña_Utilizada_Kg { get; set; }

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