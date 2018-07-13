using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProcesoLlenado{
    
    [ServiceContract]
    public interface IProcesoLlenado{

        [OperationContract]
        void insertarProcesoLlenado(Entidades.Proceso_Llenado proceso_Llenado);

        [OperationContract]
        void actualizarProcesoLlenado(Entidades.Proceso_Llenado proceso_Llenado);

        [OperationContract]
        void eliminarProcesoLlenado(int Id_Proceso_Llenado);

        [OperationContract]
        List<Entidades.Proceso_Llenado> buscarProcesoLlenado(int Id_Proceso_Llenado);

        [OperationContract]
        List<Entidades.Proceso_Llenado> listar();

    }
}
