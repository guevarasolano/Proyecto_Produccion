using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFDisposicionProductoNoConforme{

    public class DisposicionProductoNoConforme : IDisposicionProductoNoConforme{

        public void actualizarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme){
            LogicaNegocio.LNDisposicionProductoNoConforme objeto = new LogicaNegocio.LNDisposicionProductoNoConforme();
            objeto.actualizarDisposicionProductoNoConforme(disposicion_Producto_No_Conforme);
        }

        public List<Disposicion_Producto_No_Conforme> buscarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme){
            LogicaNegocio.LNDisposicionProductoNoConforme objeto = new LogicaNegocio.LNDisposicionProductoNoConforme();
            return objeto.buscarDisposicionProductoNoConforme(Id_Disposicion_Producto_No_Conforme);
        }

        public void eliminarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme){
            LogicaNegocio.LNDisposicionProductoNoConforme objeto = new LogicaNegocio.LNDisposicionProductoNoConforme();
            objeto.eliminarDisposicionProductoNoConforme(Id_Disposicion_Producto_No_Conforme);
        }

        public void insertarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme){
            LogicaNegocio.LNDisposicionProductoNoConforme objeto = new LogicaNegocio.LNDisposicionProductoNoConforme();
            objeto.insertarDisposicionProductoNoConforme(disposicion_Producto_No_Conforme);
        }

        public List<Disposicion_Producto_No_Conforme> listarDisposicionProductoNoConforme(){
            LogicaNegocio.LNDisposicionProductoNoConforme objeto = new LogicaNegocio.LNDisposicionProductoNoConforme();
            return objeto.listarDisposicionProductoNoConforme();
        }
    }
}
