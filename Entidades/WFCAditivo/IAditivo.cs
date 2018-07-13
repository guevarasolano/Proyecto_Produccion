using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WFCAditivo{
    
    [ServiceContract]
    public interface IAditivo{

        [OperationContract]
        void insertarAditivo(Entidades.Aditivo aditivo);

        [OperationContract]
        void actualizarAditivo(Entidades.Aditivo aditivo);

        [OperationContract]
        void eliminarAditivo(int Id_Aditivo);

        [OperationContract]
        List<Entidades.Aditivo> buscarAditivo(int Id_Aditivo);

        [OperationContract]
        List<Entidades.Aditivo> listarAditivo();

    }
}
