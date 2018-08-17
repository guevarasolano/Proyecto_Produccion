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
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }
                    else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }
            catch {

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
                    ViewBag.Mensaje = "Registro Eliminado";
                }
                else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro";
                }
                return RedirectToAction("Listado");

            }catch{

                return View();
            }
        }
        
       }
    }
