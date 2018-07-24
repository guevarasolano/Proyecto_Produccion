using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brix.Models{

    public class EBrix{

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Brix { get; set; }

        [Display(Name = "Brix")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public Double Bris { get; set; }

        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public Double Densidad { get; set; }

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