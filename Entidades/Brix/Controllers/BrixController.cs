using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brix.Controllers{

    public class BrixController : Controller{
        
        public ActionResult Listado(){

            ADBrix oBrix = new ADBrix();
            ModelState.Clear();
            return View(oBrix.listarBrix());
        }

        public ActionResult agregarBrix(Brix.Models.EBrix brix){

            try{
                if (ModelState.IsValid){
                    ADBrix oBrix = new ADBrix();
                    if (oBrix.insertarBrix(brix)){
                        ViewBag.Menasaje = "Se insertó el cliente correctamente";
                    }
                    else{
                        ViewBag.Menasaje = "No se insertó el cliente";
                    }

                }
            }
            catch (Exception ex){
                ex = null;
            }
            return View();
        }
        
        //get: brix/modificarBrix/5
        public ActionResult modificarBrix(int id){

            ADBrix oBrix = new ADBrix();
            return View(oBrix.listarBrix().Find(bri => bri.Id_Brix == id));
        }

        [HttpPost]
        public ActionResult modificarBrix(int id, Brix.Models.EBrix brix){

            ADBrix oBrix = new ADBrix();
            oBrix.actualizarBrix(brix);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarBrix(int id){

            try{
                ADBrix oBrix = new ADBrix();
                if (oBrix.eliminarBrix(id)){
                    ViewBag.Mensaje = "Registro de Brix Eliminado";
                }
                else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Brix";
                }
                return RedirectToAction("Listado");
            }
            catch{
                return View();
            }
        }
        
       }
    }
