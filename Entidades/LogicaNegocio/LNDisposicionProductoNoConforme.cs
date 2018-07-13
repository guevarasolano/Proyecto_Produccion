using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Prueba;

namespace LogicaNegocio{

    public class LNDisposicionProductoNoConforme{

        public void insertarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme){

            ADDisposicionProductoNoConforme objeto = new ADDisposicionProductoNoConforme();
            objeto.insertarDisposicionProductoNoConforme(disposicion_Producto_No_Conforme);
        }

        public void actualizarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme disposicion_Producto_No_Conforme){

            ADDisposicionProductoNoConforme objeto = new ADDisposicionProductoNoConforme();
            objeto.actualizarDisposicionProductoNoConforme(disposicion_Producto_No_Conforme);
        }

        public void eliminarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme){

            ADDisposicionProductoNoConforme objeto = new ADDisposicionProductoNoConforme();
            objeto.eliminarDisposicionProductoNoConforme(Id_Disposicion_Producto_No_Conforme);
        }

        public List<Entidades.Disposicion_Producto_No_Conforme> buscarDisposicionProductoNoConforme(int Id_Disposicion_Producto_No_Conforme){

            ADDisposicionProductoNoConforme objeto = new ADDisposicionProductoNoConforme();
            return objeto.buscarDisposicionProductoNoConforme(Id_Disposicion_Producto_No_Conforme);
        }

        public List<Entidades.Disposicion_Producto_No_Conforme> listarDisposicionProductoNoConforme(){

            ADDisposicionProductoNoConforme objeto = new ADDisposicionProductoNoConforme();
            return objeto.listarDisposicionProductoNoConforme();
        }

    }
}
