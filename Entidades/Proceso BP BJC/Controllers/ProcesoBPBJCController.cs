using Proceso_BP_BJC.Models;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proceso_BP_BJC.Controllers{

    public class ProcesoBPBJCController : Controller{

        public ActionResult Listado(){

            ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
            ModelState.Clear();
            return View(oBPBJC.listarProcesoBPBJC());
        }

        public ActionResult agregarProcesoBPBJC(ProcesoBPBJC proceso){

            try{
                if (ModelState.IsValid){

                    ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
                    if (oBPBJC.insertarProcesoBPBJC(proceso)){
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

        //get: procesoProcesoBPBJC/modificarProcesoBPBJC/5
        public ActionResult modificarProcesoBPBJC(int id){

            ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
            return View(oBPBJC.listarProcesoBPBJC().Find(pro => pro.Id_Proceso_BP_BJC == id));
        }

        [HttpPost]
        public ActionResult modificarProcesoBPBJC(int id, ProcesoBPBJC proceso){

            ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
            oBPBJC.actualizarProcesoBPBJC(proceso);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarProcesoBPBJC(int id){

            try{
                ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
                if (oBPBJC.eliminarProcesoBPBJC(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }
}