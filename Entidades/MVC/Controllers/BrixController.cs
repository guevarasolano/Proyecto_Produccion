using AccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class BrixController : Controller{
        
        //LISTAR:
        public ActionResult Listado(){

            ADBrix oBrix = new ADBrix();
            ModelState.Clear();
            return View(oBrix.listarBrix());

        }

        //AGREGAR:
        public ActionResult agregarBrix(Brix brix){

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
        
        //MODIFICAR:
        public ActionResult modificarBrix(int id){

            ADBrix oBrix = new ADBrix();
            return View(oBrix.listarBrix().Find(bri => bri.Id_Brix == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarBrix(int id, Brix brix){

            ADBrix oBrix = new ADBrix();
            oBrix.actualizarBrix(brix);
            return RedirectToAction("Listado");
        }

        //ELIMINAR:
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
    
