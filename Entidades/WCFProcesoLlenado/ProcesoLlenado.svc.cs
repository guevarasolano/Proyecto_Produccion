using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFProcesoLlenado{
    
    public class ProcesoLlenado : IProcesoLlenado{

        public void actualizarProcesoLlenado(Proceso_Llenado proceso_Llenado){
            LogicaNegocio.LNProcesoLlenado objeto = new LogicaNegocio.LNProcesoLlenado();
            objeto.actualizarProcesoLlenado(proceso_Llenado);
        }

        public List<Proceso_Llenado> buscarProcesoLlenado(int Id_Proceso_Llenado){
            LogicaNegocio.LNProcesoLlenado objeto = new LogicaNegocio.LNProcesoLlenado();
            return objeto.buscarProcesoLlenado(Id_Proceso_Llenado);
        }

        public void eliminarProcesoLlenado(int Id_Proceso_Llenado){
            LogicaNegocio.LNProcesoLlenado objeto = new LogicaNegocio.LNProcesoLlenado();
            objeto.eliminarProcesoLlenado(Id_Proceso_Llenado);
        }

        public void insertarProcesoLlenado(Proceso_Llenado proceso_Llenado){
            LogicaNegocio.LNProcesoLlenado objeto = new LogicaNegocio.LNProcesoLlenado();
            objeto.insertarProcesoLlenado(proceso_Llenado);
        }

        public List<Proceso_Llenado> listar(){
            LogicaNegocio.LNProcesoLlenado objeto = new LogicaNegocio.LNProcesoLlenado();
            return objeto.listarProcesoLlenado();
        }
    }
}
