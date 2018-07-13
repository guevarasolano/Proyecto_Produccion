using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNProcesoIngresoPiña{

        public void insertarProcesoIngresoPiña(Entidades.Proceso_Ingreso_Piña procesoIngresoPiña){

            ADProcesoIngresoPiña objeto = new ADProcesoIngresoPiña();
            objeto.insertarProcesoIngresoPiña(procesoIngresoPiña);
        }

        public void actualizarProcesoIngresoPiña(Entidades.Proceso_Ingreso_Piña procesoIngresoPiña){

            ADProcesoIngresoPiña objeto = new ADProcesoIngresoPiña();
            objeto.actualizarProcesoIngresoPiña(procesoIngresoPiña);
        }

        public void eliminarProcesoIngresoPiña(int Id_Proceso_Ingreso_Piña){

            ADProcesoIngresoPiña objeto = new ADProcesoIngresoPiña();
            objeto.eliminarProcesoIngresoPiña(Id_Proceso_Ingreso_Piña);
        }

        public List<Entidades.Proceso_Ingreso_Piña> buscarProcesoIngresoPiña(int Id_Proceso_Ingreso_Piña){

            ADProcesoIngresoPiña objeto = new ADProcesoIngresoPiña();
            return objeto.buscarProcesoIngresoPiña(Id_Proceso_Ingreso_Piña);
        }

        public List<Entidades.Proceso_Ingreso_Piña> listarProcesoIngresoPiña(){

            ADProcesoIngresoPiña objeto = new ADProcesoIngresoPiña();
            return objeto.listarProcesoIngresoPiña();
        }
    }
}
