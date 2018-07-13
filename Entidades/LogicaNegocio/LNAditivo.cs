using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNAditivo{

        public void insertarAditivo(Entidades.Aditivo aplicacion){

            ADAditivo objeto = new ADAditivo();
            objeto.insertarAditivo(aplicacion);
        }

        public void actualizarAditivo(Entidades.Aditivo aditivo){

            ADAditivo objeto = new ADAditivo();
            objeto.actualizarAditivo(aditivo);
        }

        public void eliminarAditivo(int Id_Aditivo){

            ADAditivo objeto = new ADAditivo();
            objeto.eliminarAditivo(Id_Aditivo);
        }

        public List<Entidades.Aditivo> buscarAditivo(int Id_Aditivo){

            ADAditivo objeto = new ADAditivo();
            return objeto.buscarAditivo(Id_Aditivo);
        }

        public List<Entidades.Aditivo> listarAditivo(){

            ADAditivo objeto = new ADAditivo();
            return objeto.listarAditivo();
        }

    }
}
