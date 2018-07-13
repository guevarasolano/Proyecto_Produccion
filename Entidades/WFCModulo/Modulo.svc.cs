using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCModulo{
    
    public class Modulo : IModulo{

        public void actualizarModulo(Entidades.Modulo modulo){
            LogicaNegocio.LNModulo objeto = new LogicaNegocio.LNModulo();
            objeto.actualizarModulo(modulo);
        }

        public List<Entidades.Modulo> buscarModulo(int Id_Modulo){
            LogicaNegocio.LNModulo objeto = new LogicaNegocio.LNModulo();
            return objeto.buscarModulo(Id_Modulo);
        }

        public void eliminarModulo(int Id_Modulo){
            LogicaNegocio.LNModulo objeto = new LogicaNegocio.LNModulo();
            objeto.eliminarModulo(Id_Modulo);
        }

        public void insertarModulo(Entidades.Modulo modulo){
            LogicaNegocio.LNModulo objeto = new LogicaNegocio.LNModulo();
            objeto.insertarModulo(modulo);
        }

        public List<Entidades.Modulo> listarModulo(){
            LogicaNegocio.LNModulo objeto = new LogicaNegocio.LNModulo();
            return objeto.listarModulo();
        }

    }
}
