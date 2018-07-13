using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCAditivo{
    
    public class Aditivo : IAditivo{

        public void actualizarAditivo(Entidades.Aditivo aplicacion){
            LogicaNegocio.LNAditivo objeto = new LogicaNegocio.LNAditivo();
            objeto.actualizarAditivo(aplicacion);
        }

        public List<Entidades.Aditivo> buscarAditivo(int Id_Aditivo){
            LogicaNegocio.LNAditivo objeto = new LogicaNegocio.LNAditivo();
            return objeto.buscarAditivo(Id_Aditivo);
        }

        public void eliminarAditivo(int Id_Aditivo){
            LogicaNegocio.LNAditivo objeto = new LogicaNegocio.LNAditivo();
            objeto.eliminarAditivo(Id_Aditivo);
        }

        public void insertarAditivo(Entidades.Aditivo aplicacion){
            LogicaNegocio.LNAditivo objeto = new LogicaNegocio.LNAditivo();
            objeto.insertarAditivo(aplicacion);
        }

        public List<Entidades.Aditivo> listarAditivo(){
            LogicaNegocio.LNAditivo objeto = new LogicaNegocio.LNAditivo();
            return objeto.listarAditivo();
        }

    }
}
