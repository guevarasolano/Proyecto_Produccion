using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using Prueba;

namespace LogicaNegocio{

    public class LNInventarioProductoTerminado{

        public void insertarInventarioProductoTerminado(Inventario_Producto_Terminado inventario_Producto_Terminado){

            ADInventarioProductoTerminado objeto = new ADInventarioProductoTerminado();
            objeto.insertarInventarioProductoTerminado(inventario_Producto_Terminado);
        }

        public void actualizarInventarioProductoTerminado(Inventario_Producto_Terminado inventario_Producto_Terminado){

            ADInventarioProductoTerminado objeto = new ADInventarioProductoTerminado();
            objeto.actualizarInventarioProductoTerminado(inventario_Producto_Terminado);
        }

        public void eliminarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado){

            ADInventarioProductoTerminado objeto = new ADInventarioProductoTerminado();
            objeto.eliminarInventarioProductoTerminado(Id_Inventario_Producto_Terminado);
        }

        public List<Inventario_Producto_Terminado> buscarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado){

            ADInventarioProductoTerminado objeto = new ADInventarioProductoTerminado();
            return objeto.buscarInventarioProductoTerminado(Id_Inventario_Producto_Terminado);

        }

        public List<Inventario_Producto_Terminado> listarInventarioProductoTerminado(){

            ADInventarioProductoTerminado objeto = new ADInventarioProductoTerminado();
            return objeto.listarInventarioProductoTerminado();

        }

    }
}
