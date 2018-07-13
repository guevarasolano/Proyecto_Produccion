using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCProcesoIngresoPiña{
    
    public class ProcesoIngresoPiña : IProcesoIngresoPiña{

        public void actualizarProcesoIngresoPiña(Entidades.Proceso_Ingreso_Piña procesoIngresoPiña){
            LogicaNegocio.LNProcesoIngresoPiña objeto = new LogicaNegocio.LNProcesoIngresoPiña();
            objeto.actualizarProcesoIngresoPiña(procesoIngresoPiña);
        }

        public List<Entidades.Proceso_Ingreso_Piña> buscarProcesoIngresoPiña(int Id_ProcesoIngresoPiña){
            LogicaNegocio.LNProcesoIngresoPiña objeto = new LogicaNegocio.LNProcesoIngresoPiña();
            return objeto.buscarProcesoIngresoPiña(Id_ProcesoIngresoPiña);
        }

        public void eliminarProcesoIngresoPiña(int Id_ProcesoIngresoPiña){
            LogicaNegocio.LNProcesoIngresoPiña objeto = new LogicaNegocio.LNProcesoIngresoPiña();
            objeto.eliminarProcesoIngresoPiña(Id_ProcesoIngresoPiña);
        }

        public void insertarProcesoIngresoPiña(Entidades.Proceso_Ingreso_Piña procesoIngresoPiña){
            LogicaNegocio.LNProcesoIngresoPiña objeto = new LogicaNegocio.LNProcesoIngresoPiña();
            objeto.insertarProcesoIngresoPiña(procesoIngresoPiña);
        }

        public List<Entidades.Proceso_Ingreso_Piña> listarProcesoIngresoPiña(){
            LogicaNegocio.LNProcesoIngresoPiña objeto = new LogicaNegocio.LNProcesoIngresoPiña();
            return objeto.listarProcesoIngresoPiña();
        }

    }
}
