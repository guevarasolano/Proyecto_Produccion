﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models{

    public class Aplicacion{

        [Display(Name = "Id")]
        public int Id_Aplicacion { get; set; }

        [Display(Name = "Codigo")]
        public String Codigo { get; set; }

        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

        [Display(Name = "Controlador")]
        public String Controlador { get; set; }

        [Display(Name = "Estado")]
        public Boolean Estado { get; set; }

        [Display(Name = "Estado Acción")]
        public String Estado_Accion { get; set; }

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