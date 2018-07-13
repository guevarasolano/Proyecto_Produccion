using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WFCInventarioProductoTerminado{

    [ServiceContract]
    public interface IInventarioProductoTerminado{

        [OperationContract]
        void insertarInventarioProductoTerminado(Entidades.Inventario_Producto_Terminado inventario_Producto_Terminado);

        [OperationContract]
        void actualizarInventarioProductoTerminado(Entidades.Inventario_Producto_Terminado inventario_Producto_Terminado);

        [OperationContract]
        void eliminarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado);

        [OperationContract]
        List<Entidades.Inventario_Producto_Terminado> buscarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado);

        [OperationContract]
        List<Entidades.Inventario_Producto_Terminado> listarInventarioProductoTerminado();

    }
}
