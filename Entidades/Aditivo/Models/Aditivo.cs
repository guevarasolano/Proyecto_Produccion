using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aditivo.Models{

    public class Aditivo{

        [Display(Name = "Id")]
        public int Id_Aditivo { get; set; }

        [Display(Name = "Id Proceso BP BJC")]
        public int FK_Id_Proceso_BP_BJC { get; set; }

        [Display(Name = "Jugo Limon")]
        public Double Jugo_Limon { get; set; }

        [Display(Name = "Ascorbico")]
        public Double Ascorbico { get; set; }

        [Display(Name = "Citrico")]
        public Double Citrico { get; set; }

        [Display(Name = "Liquiseb RL Concentrado")]
        public Double Liquiseb_RL_Concentrado { get; set; }

        [Display(Name = "Liquiseb APL")]
        public Double Liquiseb_APL { get; set; }

        [Display(Name = "Sebamyl GL400")]
        public Double Sebamyl_GL400 { get; set; }

        [Display(Name = "Sebamyl BAL100")]
        public Double Sebamyl_BAL100 { get; set; }

        [Display(Name = "Flora Clair")]
        public Double Flora_Clair { get; set; }

        [Display(Name = "Gelatina")]
        public Double Gelatina { get; set; }

        [Display(Name = "Bevasyl")]
        public Double Bevasyl { get; set; }

        [Display(Name = "Bentonita")]
        public Double Bentonita { get; set; }

        [Display(Name = "Carbon")]
        public Double Carbon { get; set; }

        [Display(Name = "Celite")]
        public Double Celite { get; set; }

        [Display(Name = "HS 4000")]
        public Double HS_4000 { get; set; }

        [Display(Name = "Shenck DD")]
        public Double Shenck_DD { get; set; }

        [Display(Name = "HS 100")]
        public Double HS_1000 { get; set; }

        [Display(Name = "HS 1600")]
        public Double HS_1600 { get; set; }

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