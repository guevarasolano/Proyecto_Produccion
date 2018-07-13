using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCAccion{
    
    public class Accion : IAccion{

        public void actualizarAccion(Entidades.Accion accion){
            LogicaNegocio.LNAccion objeto = new LogicaNegocio.LNAccion();
            objeto.actualizarAccion(accion);
        }

        public List<Entidades.Accion> buscarAccion(int Id_Accion){
            LogicaNegocio.LNAccion objeto = new LogicaNegocio.LNAccion();
            return objeto.buscarAccion(Id_Accion);
        }

        public void eliminarAccion(int Id_Accion){
            LogicaNegocio.LNAccion objeto = new LogicaNegocio.LNAccion();
            objeto.eliminarAccion(Id_Accion);
        }

        public void insertarAccion(Entidades.Accion accion){
            LogicaNegocio.LNAccion objeto = new LogicaNegocio.LNAccion();
            objeto.insertarAccion(accion);
        }

        public List<Entidades.Accion> listarAccion(){
            LogicaNegocio.LNAccion objeto = new LogicaNegocio.LNAccion();
            return objeto.listarAccion();
        }

    }
}
