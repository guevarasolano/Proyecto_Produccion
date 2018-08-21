using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio{

    public class LNProcesoBPBJC{

        public void insertarProcesoBPBJC(Entidades.Proceso_BP_BJC proceso_BP_BJC){

            ADProcesoBPBJC objeto = new ADProcesoBPBJC();
            objeto.insertarProcesoBPBJC(proceso_BP_BJC);
        }

        public void actualizarProcesoBPBJC(Entidades.Proceso_BP_BJC proceso_BP_BJC){

            ADProcesoBPBJC objeto = new ADProcesoBPBJC();
            objeto.actualizarProcesoBPBJC(proceso_BP_BJC);
        }

        public void eliminarProcesoBPBJC(int Id_Proceso_BP_BJC){

            ADProcesoBPBJC objeto = new ADProcesoBPBJC();
            objeto.eliminarProcesoBPBJC(Id_Proceso_BP_BJC);
        }

        public List<Entidades.Proceso_BP_BJC> buscarProcesoBPBJC(int Id_Proceso_BP_BJC)
        {

            ADProcesoBPBJC objeto = new ADProcesoBPBJC();
            return objeto.buscarProcesoBPBJC(Id_Proceso_BP_BJC);
        }

        public List<Entidades.Proceso_BP_BJC> listarProcesoBPBJC(){

            ADProcesoBPBJC objeto = new ADProcesoBPBJC();
            return objeto.listarProcesoBPBJC();
        }

    }
}
