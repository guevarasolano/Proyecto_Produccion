using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFDisposicionProductoNoConforme{

    [ServiceContract]
    public interface IDisposicionProductoNoConforme{

        [OperationContract]
        void insertarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme);

        [OperationContract]
        void actualizarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme);

        [OperationContract]
        void eliminarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme);

        [OperationContract]
        List<Entidades.Disposicion_Producto_No_Conforme> buscarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme);

        [OperationContract]
        List<Entidades.Disposicion_Producto_No_Conforme> listarDisposicionProductoNoConforme();

    }
}
