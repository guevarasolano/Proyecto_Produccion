using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFRol{

    
    [ServiceContract]
    public interface IRol{

        [OperationContract]
        void insertarRol(Entidades.Rol rol);

        [OperationContract]
        void actualizarRol(Entidades.Rol rol);

        [OperationContract]
        void eliminarRol(int Id_Rol);

        [OperationContract]
        List<Entidades.Rol> buscarRol(int Id_Rol);

        [OperationContract]
        List<Entidades.Rol> listarRol();

    }
}
