using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapaEntidades {

    public class ProcesoBPBJC {

        [Display(Name = "Id")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public int Id_Proceso_BP_BJC { get; set; }

        [Display(Name = "Tipo Producto")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public String Tipo_Producto { get; set; }

        [Display(Name = "Cantidad Producto Total")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public int Cantidad_Producto_Total { get; set; }

        [Display(Name = "Porcentaje Llenado")]
        //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
        public Double Porcentaje_Llenado { get; set; }

        [Display(Name = "Cantidad Cajas Usadas")]
        //[Required(ErrorMessage = "Debe digitar el Estado")]
        public int Cantidad_Cajas_Usadas { get; set; }

        [Display(Name = "Cantidad Carga Banano Verde Usado Kg")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public Double Cantidad_Carga_Banano_Verde_Usado_Kg { get; set; }

        [Display(Name = "Cantidad Carga Banano Maduro Usado Kg")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public Double Cantidad_Carga_Banano_Maduro_Usado_Kg { get; set; }

        [Display(Name = "Litros Producidos")]
        //[Required(ErrorMessage = "Debe digitar el Brix")]
        public int Litros_Producidos { get; set; }

        [Display(Name = "Transferido Tanque")]
        //[Required(ErrorMessage = "Debe digitar la Densidad")]
        public int Transferido_Tanque { get; set; }

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