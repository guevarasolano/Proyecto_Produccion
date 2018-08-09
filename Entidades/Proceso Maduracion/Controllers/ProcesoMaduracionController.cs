using Proceso_Maduracion.Models;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proceso_Maduracion.Controllers{

    public class ProcesoMaduracionController : Controller{

        public ActionResult Listado(){

            ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
            ModelState.Clear();
            return View(oMaduracion.listarProcesoMaduracion());
        }

        public ActionResult agregarProcesoMaduracion(ProcesoMaduracion maduracion){

            try{
                if (ModelState.IsValid){

                    ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
                    if (oMaduracion.insertarProcesoMaduracion(maduracion)){
                        ViewBag.Menasaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Registro";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: procesoMaduracion/modificarProcesoMaduracion/5
        public ActionResult modificarProcesoMaduracion(int id){

            ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
            return View(oMaduracion.listarProcesoMaduracion().Find(mad => mad.Id_Proceso_Maduracion == id));
        }

        [HttpPost]
        public ActionResult modificarProcesoMaduracion(int id, ProcesoMaduracion maduracion){

            ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
            oMaduracion.actualizarProcesoMaduracion(maduracion);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarProcesoMaduracion(int id){

            try{
                ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
                if (oMaduracion.eliminarProcesoMaduracion(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro";
                }
                return RedirectToAction("Listado");
            }catch (Exception e){

                return View();
            }
        }
    }
}