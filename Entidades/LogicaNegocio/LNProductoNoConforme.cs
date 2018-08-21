using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba;

namespace LogicaNegocio{

    public class LNProductoNoConforme{

        public void insertarProductoNoConforme(Entidades.Producto_No_Conforme producto_No_Conforme){

            ADProductoNoConforme objeto = new ADProductoNoConforme();
            objeto.insertarProductoNoConforme(producto_No_Conforme);
        }

        public void actualizarProductoNoConforme(Entidades.Producto_No_Conforme producto_No_Conforme){

            ADProductoNoConforme objeto = new ADProductoNoConforme();
            objeto.actualizarProductoNoConforme(producto_No_Conforme);
        }

        public void eliminarProductoNoConforme(int Id_Producto_No_Conforme){

            ADProductoNoConforme objeto = new ADProductoNoConforme();
            objeto.eliminarProductoNoConforme(Id_Producto_No_Conforme);
        }

        public List<Entidades.Producto_No_Conforme> buscarProductoNoConforme(int Id_Producto_No_Conforme){

            ADProductoNoConforme objeto = new ADProductoNoConforme();
            return objeto.buscarProductoNoConforme(Id_Producto_No_Conforme);

        }

        public List<Entidades.Producto_No_Conforme> listarProductoNoConforme(){

            ADProductoNoConforme objeto = new ADProductoNoConforme();
            return objeto.listarProductoNoConforme();

        }
    }
}
