using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProcesoBPBJC{
    
    [ServiceContract]
    public interface IProcesoBPBJC{

        [OperationContract]
        void insertarProcesoBPBJC(Entidades.Proceso_BP_BJC proceso_BP_BJC);

        [OperationContract]
        void actualizarProcesoBPBJC(Entidades.Proceso_BP_BJC proceso_BP_BJC);

        [OperationContract]
        void eliminarProcesoBPBJC(int Id_Proceso_BP_BJC);

        [OperationContract]
        List<Entidades.Proceso_BP_BJC> buscarProcesoBPBJC(int Id_Proceso_BP_BJC);

        [OperationContract]
        List<Entidades.Proceso_BP_BJC> listarProcesoBPBJC();

    }
}
