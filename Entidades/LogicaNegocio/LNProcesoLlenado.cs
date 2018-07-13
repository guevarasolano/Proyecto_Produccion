using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNProcesoLlenado{

        public void insertarProcesoLlenado(Entidades.Proceso_Llenado proceso_Llenado){

            AccesoDatos.ADProcesoLlenado objeto = new AccesoDatos.ADProcesoLlenado();
            objeto.insertarProcesoLlenado(proceso_Llenado);
        }

        public void actualizarProcesoLlenado(Entidades.Proceso_Llenado proceso_Llenado){

            AccesoDatos.ADProcesoLlenado objeto = new AccesoDatos.ADProcesoLlenado();
            objeto.actualizarProcesoLlenado(proceso_Llenado);
        }

        public void eliminarProcesoLlenado(int Id_Proceso_Llenado){

            AccesoDatos.ADProcesoLlenado objeto = new AccesoDatos.ADProcesoLlenado();
            objeto.eliminarProcesoLlenado(Id_Proceso_Llenado);
        }

        public List<Entidades.Proceso_Llenado> buscarProcesoLlenado(int Id_Proceso_Llenado){

            AccesoDatos.ADProcesoLlenado objeto = new AccesoDatos.ADProcesoLlenado();
            return objeto.buscarProcesoLlenado(Id_Proceso_Llenado);

        }

        public List<Entidades.Proceso_Llenado> listarProcesoLlenado(){

            AccesoDatos.ADProcesoLlenado objeto = new AccesoDatos.ADProcesoLlenado();
            return objeto.listar();

        }
    }
}
