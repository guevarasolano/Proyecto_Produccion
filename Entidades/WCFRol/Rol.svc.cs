using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFRol{

    public class Rol : IRol{

        public void actualizarRol(Entidades.Rol rol){
            LogicaNegocio.LNRol objeto = new LogicaNegocio.LNRol();
            objeto.actualizarRol(rol);
        }

        public List<Entidades.Rol> buscarRol(int Id_Rol){
            LogicaNegocio.LNRol objeto = new LogicaNegocio.LNRol();
            return objeto.buscarRol(Id_Rol);
        }

        public void eliminarRol(int Id_Rol){
            LogicaNegocio.LNRol objeto = new LogicaNegocio.LNRol();
            objeto.eliminarRol(Id_Rol);
        }

        public void insertarRol(Entidades.Rol rol){
            LogicaNegocio.LNRol objeto = new LogicaNegocio.LNRol();
            objeto.insertarRol(rol);
        }

        public List<Entidades.Rol> listarRol(){
            LogicaNegocio.LNRol objeto = new LogicaNegocio.LNRol();
            return objeto.listarRol();
        }

    }
}
