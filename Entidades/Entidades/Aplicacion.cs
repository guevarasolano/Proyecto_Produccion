using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    public class Aplicacion
    {
        public int Id_Aplicacion { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Controlador { get; set; }
        public bool Estado { get; set; }
        public string Estado_Accion { get; set; }
        public string Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public List<Modulo> Listado_Modulos { get; set; } 

        public Aplicacion(int Id_Aplicacion, string Codigo, string Descripcion, string Controlador, bool Estado,
                          string Estado_Accion, string Usuario_Ingreso, DateTime Fecha_Ingreso, string Usuario_Modificacion,
                          DateTime Fecha_Modificacion, List<Modulo> Listado_Modulos)
        {
            this.Id_Aplicacion = Id_Aplicacion;
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Controlador = Controlador;
            this.Estado = Estado;
            this.Estado_Accion = Estado_Accion;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
            this.Listado_Modulos = Listado_Modulos;
        }

    }
}