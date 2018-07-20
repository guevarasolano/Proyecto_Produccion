using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    public class Rol_Accion
    {
        public Rol Rol { get; set; }
        public Accion Accion { get; set; }
        public string Estado { get; set; }
        public string Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Rol_Accion(Rol Rol, Accion Accion, string Estado, string Usuario_Ingreso, DateTime Fecha_Ingreso,
                          string Usuario_Modificacion, DateTime Fecha_Modificacion)
        {
            this.Rol = Rol;
            this.Accion = Accion;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }
    }
}
