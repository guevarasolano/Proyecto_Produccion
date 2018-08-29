﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades{

    public class Persona{

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Persona { get; set; }

        [Display(Name = "Nombre")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Primer_Apellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Segundo_Apellido { get; set; }

        [Display(Name = "Sexo")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public String Sexo { get; set; }

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