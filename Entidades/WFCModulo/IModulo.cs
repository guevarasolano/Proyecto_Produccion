using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WFCModulo{
    
    [ServiceContract]
    public interface IModulo{

        [OperationContract]
        void insertarModulo(Entidades.Modulo modulo);

        [OperationContract]
        void actualizarModulo(Entidades.Modulo modulo);

        [OperationContract]
        void eliminarModulo(int Id_Modulo);

        [OperationContract]
        List<Entidades.Modulo> buscarModulo(int Modulo);

        [OperationContract]
        List<Entidades.Modulo> listarModulo();

    }
}
