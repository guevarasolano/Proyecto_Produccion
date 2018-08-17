using Proceso_BP_BJC.Models;
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proceso_BP_BJC.Controllers{

    public class ProcesoBPBJCController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
            ModelState.Clear();
            return View(oBPBJC.listarProcesoBPBJC());

        }

        //AGREGAR:
        public ActionResult agregarProcesoBPBJC(ProcesoBPBJC proceso){

            try{
                if (ModelState.IsValid){

                    ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
                    if (oBPBJC.insertarProcesoBPBJC(proceso)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }catch{

            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarProcesoBPBJC(int id){

            ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
            return View(oBPBJC.listarProcesoBPBJC().Find(pro => pro.Id_Proceso_BP_BJC == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarProcesoBPBJC(int id, ProcesoBPBJC proceso){

            ADProcesoBPBJC oBPBJC = new ADProcesoBPBJC();
            oBPBJC.actualizarProcesoBPBJC(proceso);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
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