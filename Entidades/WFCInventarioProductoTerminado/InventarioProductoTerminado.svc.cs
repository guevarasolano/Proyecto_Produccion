using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using LogicaNegocio;

namespace WFCInventarioProductoTerminado{

    public class InventarioProductoTerminado : IInventarioProductoTerminado {

        public void actualizarInventarioProductoTerminado(Inventario_Producto_Terminado inventario_Producto_Terminado) {
            LNInventarioProductoTerminado objeto = new LNInventarioProductoTerminado();
            objeto.actualizarInventarioProductoTerminado(inventario_Producto_Terminado);
        }

        public List<Inventario_Producto_Terminado> buscarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado) {
            LNInventarioProductoTerminado objeto = new LNInventarioProductoTerminado();
            return objeto.buscarInventarioProductoTerminado(Id_Inventario_Producto_Terminado);
        }

        public void eliminarInventarioProductoTerminado(int Id_Inventario_Producto_Terminado) {
            LNInventarioProductoTerminado objeto = new LNInventarioProductoTerminado();
            objeto.eliminarInventarioProductoTerminado(Id_Inventario_Producto_Terminado);
        }

        public void insertarInventarioProductoTerminado(Inventario_Producto_Terminado inventario_Producto_Terminado){
            LNInventarioProductoTerminado objeto = new LNInventarioProductoTerminado();
            objeto.insertarInventarioProductoTerminado(inventario_Producto_Terminado);
        }

        public List<Inventario_Producto_Terminado> listarInventarioProductoTerminado() {
            LNInventarioProductoTerminado objeto = new LNInventarioProductoTerminado();
            return objeto.listarInventarioProductoTerminado();
        }

        }

    }

