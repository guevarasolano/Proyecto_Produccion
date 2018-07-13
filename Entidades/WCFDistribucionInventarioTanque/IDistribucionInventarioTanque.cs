using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFDistribucionInventarioTanque{

    [ServiceContract]
    public interface IDistribucionInventarioTanque{

        [OperationContract]
        void insertarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque);

        [OperationContract]
        void actualizarDistribucionInventarioTanque(Distribucion_Inventario_Tanque distribucion_Inventario_Tanque);

        [OperationContract]
        void eliminarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque);

        [OperationContract]
        List<Distribucion_Inventario_Tanque> buscarDistribucionInventarioTanque(int Id_Distribucion_Inventario_Tanque);

        [OperationContract]
        List<Distribucion_Inventario_Tanque> listarDistribucionInventarioTanque();

        [OperationContract]
        List<Distribucion_Inventario_Tanque> buscarDistribucionPorTanque(int Numero_Tanque);

    }
}
