using Proceso_Ingreso_Piña.Models;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proceso_Ingreso_Piña.Controllers{

    public class ProcesoIngresoPiñaController : Controller{

        public ActionResult Listado(){

            ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
            ModelState.Clear();
            return View(oIngreso.listarProcesoIngresoPiña());
        }

        public ActionResult agregarProcesoIngresoPiña(ProcesoIngresoPiña ingreso){

            try{
                if (ModelState.IsValid){
                    ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
                    if (oIngreso.insertarProcesoIngresoPiña(ingreso)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el registro";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: procesoIngresoPiña/modificarProcesoIngresoPiña/5
        public ActionResult modificarProcesoIngresoPiña(int id){

            ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
            return View(oIngreso.listarProcesoIngresoPiña().Find(piñ => piñ.Id_Proceso_Ingreso_Piña == id));
        }

        [HttpPost]
        public ActionResult modificarProcesoIngresoPiña(int id, ProcesoIngresoPiña ingreso){

            ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
            oIngreso.actualizarProcesoIngresoPiña(ingreso);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarProcesoIngresoPiña(int id){

            try{
                ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
                if (oIngreso.eliminarProcesoIngresoPiña(id)){
                    ViewBag.Mensaje = "Registro de Ingreso Piña Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Ingreso Piña";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }
}