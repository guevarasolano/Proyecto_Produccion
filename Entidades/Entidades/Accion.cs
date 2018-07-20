using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    public class Accion
    {
        public int Id_Accion { get; set; }
        public int Id_Modulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Estado_Accion { get; set; }
        public string Usuario_Ingreso { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

        public Accion(int Id_Accion, int Id_Modulo, string Codigo, string Descripcion, bool Estado, string Estado_Accion,
                      string Usuario_Ingreso, DateTime Fecha_Ingreso, string Usuario_Modificacion, DateTime Fecha_Modificacion)
        {
            this.Id_Accion = Id_Accion;
            this.Id_Modulo = Id_Modulo;
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
            this.Estado_Accion = Estado_Accion;
            this.Usuario_Ingreso = Usuario_Ingreso;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Usuario_Modificacion = Usuario_Modificacion;
            this.Fecha_Modificacion = Fecha_Modificacion;
        }

    }
}
