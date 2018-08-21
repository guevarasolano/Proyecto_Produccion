using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNProcesoMaduracion{

        public void insertarProcesoMaduracion(Entidades.Proceso_Maduracion proceso_Maduracion){

            ADProcesoMaduracion objeto = new ADProcesoMaduracion();
            objeto.insertarProcesoMaduracion(proceso_Maduracion);
        }

        public void actualizarProcesoMaduracion(Entidades.Proceso_Maduracion proceso_Maduracion){

            ADProcesoMaduracion objeto = new ADProcesoMaduracion();
            objeto.actualizarProcesoMaduracion(proceso_Maduracion);
        }

        public void eliminarProcesoMaduracion(int Id_Proceso_Maduracion){

            ADProcesoMaduracion objeto = new ADProcesoMaduracion();
            objeto.eliminarProcesoMaduracion(Id_Proceso_Maduracion);
        }

        public List<Entidades.Proceso_Maduracion> buscarProcesoMaduracion(int Id_Proceso_Maduracion){

            ADProcesoMaduracion objeto = new ADProcesoMaduracion();
            return objeto.buscarProcesoMaduracion(Id_Proceso_Maduracion);
        }

        public List<Entidades.Proceso_Maduracion> listarProcesoMaduracion(){

            ADProcesoMaduracion objeto = new ADProcesoMaduracion();
            return objeto.listarProcesoMaduracion();
        }

    }
}
