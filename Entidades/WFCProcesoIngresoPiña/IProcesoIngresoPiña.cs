using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCProcesoIngresoPiña{
    
    [ServiceContract]
    public interface IProcesoIngresoPiña{

        [OperationContract]
        void insertarProcesoIngresoPiña(Entidades.Proceso_Ingreso_Piña procesoIngresoPiña);

        [OperationContract]
        void actualizarProcesoIngresoPiña(Entidades.Proceso_Ingreso_Piña procesoIngresoPiña);

        [OperationContract]
        void eliminarProcesoIngresoPiña(int Id_ProcesoIngresoPiña);

        [OperationContract]
        List<Entidades.Proceso_Ingreso_Piña> buscarProcesoIngresoPiña(int Proceso_Ingreso_Piña);

        [OperationContract]
        List<Entidades.Proceso_Ingreso_Piña> listarProcesoIngresoPiña();

    }
}
