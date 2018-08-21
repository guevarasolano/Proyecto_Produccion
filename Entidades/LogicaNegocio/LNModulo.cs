using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNModulo{

        public void insertarModulo(Entidades.Modulo aplicacion){

            ADModulo objeto = new ADModulo();
            objeto.insertarModulo(aplicacion);
        }

        public void actualizarModulo(Entidades.Modulo aplicacion){

            ADModulo objeto = new ADModulo();
            objeto.actualizarModulo(aplicacion);
        }

        public void eliminarModulo(int Id_Modulo){

            ADModulo objeto = new ADModulo();
            objeto.eliminarModulo(Id_Modulo);
        }

        public List<Entidades.Modulo> buscarModulo(int Id_Modulo){

            ADModulo objeto = new ADModulo();
            return objeto.buscarModulo(Id_Modulo);
        }

        public List<Entidades.Modulo> listarModulo(){

            ADModulo objeto = new ADModulo();
            return objeto.listarModulo();
        }

    }
}
