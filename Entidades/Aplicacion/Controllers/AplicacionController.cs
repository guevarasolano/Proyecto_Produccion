using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion.Controllers{

    public class AplicacionController : Controller{

        public ActionResult Listado(){

            ADAplicacion oAplicacion = new ADAplicacion();
            ModelState.Clear();
            return View(oAplicacion.listarAplicacion());
        }

        public ActionResult agregarAplicacion(Aplicacion.Models.Aplicacion aplicacion){

            try{
                if (ModelState.IsValid){

                    ADAplicacion oAplicacion = new ADAplicacion();
                    if (oAplicacion.insertarAplicacion(aplicacion)){
                        ViewBag.Menasaje = "Se insertó la aplicación correctamente";
                    }
                    else{
                        ViewBag.Menasaje = "No se insertó la aplicacion";
                    }

                }
            }
            catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: aplicacion/modificarAplicacion/5
        public ActionResult modificarAplicacion(int id){

            ADAplicacion oAplicacion = new ADAplicacion();
            return View(oAplicacion.listarAplicacion().Find(apli => apli.Id_Aplicacion == id));
        }

        [HttpPost]
        public ActionResult modificarAplicacion(int id, Aplicacion.Models.Aplicacion aplicacion){

            ADAplicacion oAplicacion = new ADAplicacion();
            oAplicacion.actualizarAplicacion(aplicacion);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarAplicacion(int id){

            try{
                ADAplicacion oAplicacion = new ADAplicacion();
                if (oAplicacion.eliminarAplicacion(id)){
                    ViewBag.Mensaje = "Registro de Aplicacion Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Aplicacion";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }
}