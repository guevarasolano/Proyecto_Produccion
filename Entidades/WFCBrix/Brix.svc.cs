using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WFCBrix{
    
    public class Brix : IBrix{

        public void actualizarBrix(Entidades.Brix brix){
            LogicaNegocio.LNBrix objeto = new LogicaNegocio.LNBrix();
            objeto.actualizarBrix(brix);
        }

        public List<Entidades.Brix> buscarBrix(int Id_Brix){
            LogicaNegocio.LNBrix objeto = new LogicaNegocio.LNBrix();
            return objeto.buscarBrix(Id_Brix);
        }

        public void eliminarBrix(int Id_Brix){
            LogicaNegocio.LNBrix objeto = new LogicaNegocio.LNBrix();
            objeto.eliminarBrix(Id_Brix);
        }

        public void insertarBrix(Entidades.Brix brix){
            LogicaNegocio.LNBrix objeto = new LogicaNegocio.LNBrix();
            objeto.insertarBrix(brix);
        }

        public List<Entidades.Brix> listarBrix(){
            LogicaNegocio.LNBrix objeto = new LogicaNegocio.LNBrix();
            return objeto.listarBrix();
        }

    }
}
