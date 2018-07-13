using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFAplicacion{

    public class Aplicacion : IAplicacion{

        public void actualizarAplicacion(Entidades.Aplicacion aplicacion){
            LogicaNegocio.LNAplicacion objeto = new LogicaNegocio.LNAplicacion();
            objeto.actualizarAplicacion(aplicacion);
        }

        public List<Entidades.Aplicacion> buscarAplicacion(int Id_Aplicacion){
            LogicaNegocio.LNAplicacion objeto = new LogicaNegocio.LNAplicacion();
            return objeto.buscarAplicacion(Id_Aplicacion);
        }

        public void eliminarAplicacion(int Id_Aplicacion){
            LogicaNegocio.LNAplicacion objeto = new LogicaNegocio.LNAplicacion();
            objeto.eliminarAplicacion(Id_Aplicacion);
        }

        public void insertarAplicacion(Entidades.Aplicacion aplicacion){
            LogicaNegocio.LNAplicacion objeto = new LogicaNegocio.LNAplicacion();
            objeto.insertarAplicacion(aplicacion);
        }

        public List<Entidades.Aplicacion> listarAplicacion(){
            LogicaNegocio.LNAplicacion objeto = new LogicaNegocio.LNAplicacion();
            return objeto.listarAplicacion();
        }
    }
}
