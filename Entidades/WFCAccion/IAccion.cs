using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WFCAccion{

    [ServiceContract]
    public interface IAccion{

        [OperationContract]
        void insertarAccion(Entidades.Accion usuario);

        [OperationContract]
        void actualizarAccion(Entidades.Accion usuario);

        [OperationContract]
        void eliminarAccion(int Id_Accion);

        [OperationContract]
        List<Entidades.Accion> buscarAccion(int Id_Accion);

        [OperationContract]
        List<Entidades.Accion> listarAccion();

    }
}
