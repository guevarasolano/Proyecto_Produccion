using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFAplicacion{

    [ServiceContract]
    public interface IAplicacion{

        [OperationContract]
        void insertarAplicacion(Entidades.Aplicacion aplicacion);

        [OperationContract]
        void actualizarAplicacion(Entidades.Aplicacion aplicacion);

        [OperationContract]
        void eliminarAplicacion(int Id_Aplicacion);

        [OperationContract]
        List<Entidades.Aplicacion> buscarAplicacion(int Id_Aplicacion);

        [OperationContract]
        List<Entidades.Aplicacion> listarAplicacion();

    }
}
