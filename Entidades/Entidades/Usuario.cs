using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Dominio { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre_Completo { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Correo_Electronico { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_Ultimo_Acceso { get; set; }
        public string Estado_Accion { get; set; }
        public string Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Usuario(int Id_Usuario, string Dominio, string Nombre_Usuario, string Nombre_Completo, string Primer_Apellido,
                       string Segundo_Apellido, string Correo_Electronico, bool Estado, DateTime Fecha_Ultimo_Acceso, string Estado_Accion,
                       string Usuario_Ingreso, DateTime Fecha_Ingreso, string Usuario_Modificacion, DateTime Fecha_Modificacion)
        {
            this.Id_Usuario = Id_Usuario;
            this.Dominio = Dominio;
            this.Nombre_Usuario = Nombre_Usuario;
            this.Nombre_Completo = Nombre_Completo;
            this.Primer_Apellido = Primer_Apellido;
            this.Segundo_Apellido = Segundo_Apellido;
            this.Correo_Electronico = Correo_Electronico;
            this.Estado = Estado;
            this.Fecha_Ultimo_Acceso = Fecha_Ultimo_Acceso;
            this.Estado_Accion = Estado_Accion;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }
    }
}
