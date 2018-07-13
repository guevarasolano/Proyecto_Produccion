using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCBrix{
    
    [ServiceContract]
    public interface IBrix{

        [OperationContract]
        void insertarBrix(Entidades.Brix brix);

        [OperationContract]
        void actualizarBrix(Entidades.Brix brix);

        [OperationContract]
        void eliminarBrix(int Id_Brix);

        [OperationContract]
        List<Entidades.Brix> buscarBrix(int Id_Brix);

        [OperationContract]
        List<Entidades.Brix> listarBrix();

    }
}
