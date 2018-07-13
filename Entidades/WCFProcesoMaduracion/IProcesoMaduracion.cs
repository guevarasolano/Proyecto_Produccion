using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProcesoMaduracion{
    
    [ServiceContract]
    public interface IProcesoMaduracion{

        [OperationContract]
        void insertarProcesoMaduracion(Entidades.Proceso_Maduracion proceso_Maduracion);

        [OperationContract]
        void actualizarProcesoMaduracion(Entidades.Proceso_Maduracion proceso_Maduracion);

        [OperationContract]
        void eliminarProcesoMaduracion(int Id_Proceso_Maduracion);

        [OperationContract]
        List<Entidades.Proceso_Maduracion> buscarProcesoMaduracion(int Id_Proceso_Maduracion);

        [OperationContract]
        List<Entidades.Proceso_Maduracion> listarProcesoMaduracion();

    }
}
