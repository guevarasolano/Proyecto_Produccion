using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFProductoNoConforme{

    [ServiceContract]
    public interface IProductoNoConforme{

        [OperationContract]
        void insertarProductoNoConforme(Producto_No_Conforme producto_No_Conforme);

        [OperationContract]
        void actualizarProductoNoConforme(Producto_No_Conforme producto_No_Conforme);

        [OperationContract]
        void eliminarProductoNoConforme(int Id_Producto_No_Conforme);

        [OperationContract]
        List <Producto_No_Conforme> buscarProductoNoConforme(int Id_Producto_No_Conforme);

        [OperationContract]
        List<Producto_No_Conforme> listarProductoNoConforme();

    }
}
