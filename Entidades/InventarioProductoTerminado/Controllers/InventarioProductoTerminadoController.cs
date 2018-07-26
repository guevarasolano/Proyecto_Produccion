using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventarioProductoTerminado.Controllers{

    public class InventarioProductoTerminadoController : Controller{

        public ActionResult Listado(){

            ADInventarioProductoTerminado oInventario = new ADInventarioProductoTerminado();
            ModelState.Clear();
            return View(oInventario.listarInventarioProductoTerminado());
        }

        public ActionResult agregarInventarioProductoTerminado(InventarioProductoTerminado.Models.InventarioProductoTerminado inventario){

            try{
                if (ModelState.IsValid){

                    ADInventarioProductoTerminado oAplicacion = new ADInventarioProductoTerminado();
                    if (oAplicacion.insertarInventarioProductoTerminado(inventario)){
                        ViewBag.Menasaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Registro";
                    }

                }
            }
            catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: inventarioProductoTerminado/modificarInventarioProductoTerminado/5
        public ActionResult modificarInventarioProductoTerminado(int id){

            ADInventarioProductoTerminado oAplicacion = new ADInventarioProductoTerminado();
            return View(oAplicacion.listarInventarioProductoTerminado().Find(inv => inv.Id_Inventario_Producto_Terminado== id));
        }

        [HttpPost]
        public ActionResult modificarInventarioProductoTerminado(int id, InventarioProductoTerminado.Models.InventarioProductoTerminado inventario){

            ADInventarioProductoTerminado oAplicacion = new ADInventarioProductoTerminado();
            oAplicacion.actualizarInventarioProductoTerminado(inventario);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarInventarioProductoTerminado(int id){

            try{
                ADInventarioProductoTerminado oAplicacion = new ADInventarioProductoTerminado();
                if (oAplicacion.eliminarInventarioProductoTerminado(id))
                {
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro";
                }
                return RedirectToAction("Listado");
            }
            catch{
                return View();
            }
        }

    }
}