using Aditivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class AditivoController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADAditivo oAditivo = new ADAditivo();
            ModelState.Clear();
            return View(oAditivo.listarAditivo());
        }

        //AGREGAR:
        public ActionResult agregarAditivo(Aditivo.Models.Aditivo aditivo){

            try{
                if (ModelState.IsValid){

                    ADAditivo oAditivo = new ADAditivo();
                    if (oAditivo.insertarAditivo(aditivo)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }catch {
                
            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarAditivo(int id){

            ADAditivo oAditivo = new ADAditivo();
            return View(oAditivo.listarAditivo().Find(adi => adi.Id_Aditivo == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarAditivo(int id, Aditivo.Models.Aditivo aditivo){

            ADAditivo oAditivo = new ADAditivo();
            oAditivo.actualizarAditivo(aditivo);
            return RedirectToAction("Listado");
        }

        //ELIMINAR:
        public ActionResult eliminarAditivo(int id){

            try{
                ADAditivo oAditivo = new ADAditivo();
                if (oAditivo.eliminarAditivo(id)){
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