using InventarioProductoTerminado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class InventarioProductoTerminadoController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADInventarioProductoTerminado oInventario = new ADInventarioProductoTerminado();
            ModelState.Clear();
            return View(oInventario.listarInventarioProductoTerminado());

        }

        //AGREGAR:
        public ActionResult agregarInventarioProductoTerminado(InventarioProductoTerminado.Models.InventarioProductoTerminado inventario){

            try{
                if (ModelState.IsValid){

                    ADInventarioProductoTerminado oInventario = new ADInventarioProductoTerminado();
                    if (oInventario.insertarInventarioProductoTerminado(inventario)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }
            catch {

            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarInventarioProductoTerminado(int id){

            ADInventarioProductoTerminado oInventario = new ADInventarioProductoTerminado();
            return View(oInventario.listarInventarioProductoTerminado().Find(inv => inv.Id_Inventario_Producto_Terminado == id));

        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarInventarioProductoTerminado(int id, InventarioProductoTerminado.Models.InventarioProductoTerminado inventario){

            ADInventarioProductoTerminado oInventario = new ADInventarioProductoTerminado();
            oInventario.actualizarInventarioProductoTerminado(inventario);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
        public ActionResult eliminarInventarioProductoTerminado(int id){

            try{
                ADInventarioProductoTerminado oInventario = new ADInventarioProductoTerminado();
                if (oInventario.eliminarInventarioProductoTerminado(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "No se insertó el Registro";
                }
                return RedirectToAction("Listado");
            }catch{

                return View();
            }
        }

    }