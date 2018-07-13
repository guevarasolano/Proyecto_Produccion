using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProcesoMaduracion{
    
    public class ProcesoMaduracion : IProcesoMaduracion{

        public void actualizarProcesoMaduracion(Proceso_Maduracion proceso_Maduracion){
            LogicaNegocio.LNProcesoMaduracion objeto = new LogicaNegocio.LNProcesoMaduracion();
            objeto.actualizarProcesoMaduracion(proceso_Maduracion);
        }

        public List<Proceso_Maduracion> buscarProcesoMaduracion(int Id_Proceso_Maduracion){
            LogicaNegocio.LNProcesoMaduracion objeto = new LogicaNegocio.LNProcesoMaduracion();
            return objeto.buscarProcesoMaduracion(Id_Proceso_Maduracion);
        }

        public void eliminarProcesoMaduracion(int Id_ProcesoMaduracion){
            LogicaNegocio.LNProcesoMaduracion objeto = new LogicaNegocio.LNProcesoMaduracion();
            objeto.eliminarProcesoMaduracion(Id_ProcesoMaduracion);
        }

        public void insertarProcesoMaduracion(Proceso_Maduracion proceso_Maduracion){
            LogicaNegocio.LNProcesoMaduracion objeto = new LogicaNegocio.LNProcesoMaduracion();
            objeto.insertarProcesoMaduracion(proceso_Maduracion);
        }

        public List<Proceso_Maduracion> listarProcesoMaduracion(){
            LogicaNegocio.LNProcesoMaduracion objeto = new LogicaNegocio.LNProcesoMaduracion();
            return objeto.listarProcesoMaduracion();
        }

    }
}
