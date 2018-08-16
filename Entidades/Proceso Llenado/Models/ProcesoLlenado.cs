using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

    public class ProcesoLlenado{

    [Display(Name = "Id")]
    //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
    public int Id_Proceso_Llenado { get; set; }

    [Display(Name = "FK Id Articulo SAP")]
    //[Required(ErrorMessage = "Debe digitar el Brix")]
    public int FK_Id_Articulo_SAP { get; set; }

    [Display(Name = "FK Id Calidad SAP")]
    //[Required(ErrorMessage = "Debe digitar la Densidad")]
    public int FK_Id_Calidad_SAP { get; set; }

    [Display(Name = "Numero Tanque")]
    //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
    public int Numero_Tanque { get; set; }

    [Display(Name = "Numero Aseptica")]
    //[Required(ErrorMessage = "Debe digitar el Estado")]
    public int Numero_Aseptica { get; set; }

    [Display(Name = "Numero Llenadora")]
    //[Required(ErrorMessage = "Debe digitar el Estado")]
    public int Numero_Llenadora { get; set; }

    [Display(Name = "Lote Proceso")]
    //[Required(ErrorMessage = "Debe digitar el Brix")]
    public String Lote_Proceso { get; set; }

    [Display(Name = "Fecha Llenado")]
    //[Required(ErrorMessage = "Debe digitar la Densidad")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime Fecha_Llenado { get; set; }

    [Display(Name = "Unidad Inicial")]
    //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
    public int Unidad_Inicial { get; set; }

    [Display(Name = "Unidad Final")]
    //[Required(ErrorMessage = "Debe digitar el Brix")]
    public int Unidad_Final { get; set; }

    [Display(Name = "Cantidad Muestras")]
    //[Required(ErrorMessage = "Debe digitar la Densidad")]
    public int Cantidad_Muestras { get; set; }

    [Display(Name = "Cantidad Bolsas Mezcla")]
    //[Required(ErrorMessage = "Debe digitar el Id del Brix")]
    public int Cantidad_Bolsas_Mezcla { get; set; }

    [Display(Name = "Cantidad Unidades Segunda")]
    //[Required(ErrorMessage = "Debe digitar el Estado")]
    public int Cantidad_Unidades_Segunda { get; set; }

    [Display(Name = "Id Articulo Bolsa SAP")]
    //[Required(ErrorMessage = "Debe digitar el Brix")]
    public int FK_Id_Articulo_Bolsa_SAP { get; set; }

    [Display(Name = "Lote Bolsa")]
    //[Required(ErrorMessage = "Debe digitar la Densidad")]
    public String Lote_Bolsa { get; set; }

    [Display(Name = "Comentarios")]
    //[Required(ErrorMessage = "Debe digitar el Estado")]
    public String Comentarios { get; set; }

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
