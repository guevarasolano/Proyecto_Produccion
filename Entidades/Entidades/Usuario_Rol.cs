using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    public class Usuario_Rol
    {
        public Usuario Usuario { get; set; }
        public Rol Rol { get; set; }
        public string Estado { get; set; }
        public string Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Usuario_Rol(Usuario Usuario, Rol Rol, string Estado, string Usuario_Ingreso, DateTime Fecha_Ingreso,
                           string Usuario_Modificacion, DateTime Fecha_Modificacion)
        {
            this.Usuario = Usuario;
            this.Rol = Rol;
            this.Estado = Estado;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }
    }
}
