using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProcesoBPBJC{
    
    public class ProcesoBPBJC : IProcesoBPBJC{

        public void actualizarProcesoBPBJC(Entidades.Proceso_BP_BJC proceso_BP_BJC){
            LogicaNegocio.LNProcesoBPBJC objeto = new LogicaNegocio.LNProcesoBPBJC();
            objeto.actualizarProcesoBPBJC(proceso_BP_BJC);
        }

        public List<Entidades.Proceso_BP_BJC> buscarProcesoBPBJC(int Id_Proceso_BP_BJC){
            LogicaNegocio.LNProcesoBPBJC objeto = new LogicaNegocio.LNProcesoBPBJC();
            return objeto.buscarProcesoBPBJC(Id_Proceso_BP_BJC);
        }

        public void eliminarProcesoBPBJC(int Id_Proceso_BP_BJC){
            LogicaNegocio.LNProcesoBPBJC objeto = new LogicaNegocio.LNProcesoBPBJC();
            objeto.eliminarProcesoBPBJC(Id_Proceso_BP_BJC);
        }

        public void insertarProcesoBPBJC(Entidades.Proceso_BP_BJC proceso_BP_BJC){
            LogicaNegocio.LNProcesoBPBJC objeto = new LogicaNegocio.LNProcesoBPBJC();
            objeto.insertarProcesoBPBJC(proceso_BP_BJC);
        }

        public List<Entidades.Proceso_BP_BJC> listarProcesoBPBJC(){
            LogicaNegocio.LNProcesoBPBJC objeto = new LogicaNegocio.LNProcesoBPBJC();
            return objeto.listarProcesoBPBJC();
        }

    }
}
