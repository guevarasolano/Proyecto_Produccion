using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WCFProductoNoConforme{

    public class ProductoNoConforme : IProductoNoConforme{

        public void insertarProductoNoConforme(Producto_No_Conforme producto_No_Conforme){
            LogicaNegocio.LNProductoNoConforme objeto = new LogicaNegocio.LNProductoNoConforme();
            objeto.insertarProductoNoConforme(producto_No_Conforme);
        }

        public void actualizarProductoNoConforme(Producto_No_Conforme producto_No_Conforme){
            LogicaNegocio.LNProductoNoConforme objeto = new LogicaNegocio.LNProductoNoConforme();
            objeto.actualizarProductoNoConforme(producto_No_Conforme);
        }

        public void eliminarProductoNoConforme(int Id_Producto_No_Conforme){
            LogicaNegocio.LNProductoNoConforme objeto = new LogicaNegocio.LNProductoNoConforme();
            objeto.eliminarProductoNoConforme(Id_Producto_No_Conforme);
        }

        public List<Producto_No_Conforme> buscarProductoNoConforme(int Id_Producto_No_Conforme){
            LogicaNegocio.LNProductoNoConforme objeto = new LogicaNegocio.LNProductoNoConforme();
            return objeto.buscarProductoNoConforme(Id_Producto_No_Conforme);
        }        

        public List<Producto_No_Conforme> listarProductoNoConforme(){
            LogicaNegocio.LNProductoNoConforme objeto = new LogicaNegocio.LNProductoNoConforme();
            return objeto.listarProductoNoConforme();
        } 
    }
}
