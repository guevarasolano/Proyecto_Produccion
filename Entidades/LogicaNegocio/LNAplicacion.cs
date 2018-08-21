using Entidades;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio{

    public class LNAplicacion{

        public void insertarAplicacion(Entidades.Aplicacion aplicacion){

            ADAplicacion objeto = new ADAplicacion();
            objeto.insertarAplicacion(aplicacion);
        }

        public void actualizarAplicacion(Entidades.Aplicacion aplicacion){

            ADAplicacion objeto = new ADAplicacion();
            objeto.actualizarAplicacion(aplicacion);
        }

        public void eliminarAplicacion(int Id_Aplicacion){

            ADAplicacion objeto = new ADAplicacion();
            objeto.eliminarAplicacion(Id_Aplicacion);
        }

        public List<Entidades.Aplicacion> buscarAplicacion(int Id_Aplicacion){

            ADAplicacion objeto = new ADAplicacion();
            return objeto.buscarAplicacion(Id_Aplicacion);
        }

        public List<Entidades.Aplicacion> listarAplicacion(){

            ADAplicacion objeto = new ADAplicacion();
            return objeto.listarAplicacion();
        }
    }
}
