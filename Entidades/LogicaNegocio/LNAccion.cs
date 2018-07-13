using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNAccion{

        public void insertarAccion(Entidades.Accion accion){

            ADAccion objeto = new ADAccion();
            objeto.insertarAccion(accion);
        }

        public void actualizarAccion(Entidades.Accion accion){

            ADAccion objeto = new ADAccion();
            objeto.actualizarAccion(accion);
        }

        public void eliminarAccion(int Id_Accion){

            ADAccion objeto = new ADAccion();
            objeto.eliminarAccion(Id_Accion);
        }

        public List<Entidades.Accion> buscarAccion(int Id_Accion){

            ADAccion objeto = new ADAccion();
            return objeto.buscarAccion(Id_Accion);
        }

        public List<Entidades.Accion> listarAccion(){

            ADAccion objeto = new ADAccion();
            return objeto.listarAccion();
        }

    }
}
