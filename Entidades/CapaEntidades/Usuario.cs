using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapaEntidades{

    public class Usuario{

        [Display(Name = "Id")]
        public int Id_Usuario { get; set; }

        [Display(Name = "Dominio")]
        public String Dominio { get; set; }

        [Display(Name = "Nombre Usuario")]
        public String Nombre_Usuario { get; set; }

        [Display(Name = "Nombre Completo")]
        public String Nombre_Completo { get; set; }

        [Display(Name = "Primer Apellido")]
        public String Primer_Apellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public String Segundo_Apellido { get; set; }

        [Display(Name = "Correo Electronico")]
        public String Correo_Electronico { get; set; }

        [Display(Name = "Estado")]
        public Boolean Estado { get; set; }

        [Display(Name = "Fecha Ultimo Acceso")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha_Ultimo_Acceso { get; set; }

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