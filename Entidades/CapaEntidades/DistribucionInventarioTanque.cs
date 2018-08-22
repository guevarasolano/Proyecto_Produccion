using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapaEntidades { 

    public class DistribucionInventarioTanque {

    [Display(Name = "Id")]
    //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
    public int Id_Distribucion_Inventario_Tanque { get; set; }

    [Display(Name = "Id Brix")]
    //[Required(ErrorMessage = "Debe digitar el Brix")]
    public int FK_Id_Brix { get; set; }

    [Display(Name = "Numero Tanque")]
    //[Required(ErrorMessage = "Debe digitar la Densidad")]
    public int Numero_Tanque { get; set; }

    [Display(Name = "Litros")]
    //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
    public Double Litros { get; set; }

    [Display(Name = "Kilogramos Tanque")]
    //[Required(ErrorMessage = "Debe digitar el Estado")]
    public Double Kilogramos_Tanque { get; set; }

    [Display(Name = "Estimado Cantidad Estañones")]
    //[Required(ErrorMessage = "Debe digitar el Brix")]
    public int Estimado_Cantidad_Estañones { get; set; }

    [Display(Name = "Estimado Cantidad Bines")]
    //[Required(ErrorMessage = "Debe digitar la Densidad")]
    public int Estimado_Cantidad_Bines { get; set; }

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