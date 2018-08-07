using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aditivo.Controllers{

    public class AditivoController : Controller{

        public ActionResult Listado(){

            ADAditivo oAditivo = new ADAditivo();
            ModelState.Clear();
            return View(oAditivo.listarAditivo());
        }

        public ActionResult agregarAditivo(Aditivo.Models.Aditivo aditivo){

            try{
                if (ModelState.IsValid){

                    ADAditivo oAditivo = new ADAditivo();
                    if (oAditivo.insertarAditivo(aditivo)){
                        ViewBag.Menasaje = "Se insertó el Aditivo correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Aditivo";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: aditivo/modificarAditivo/5
        public ActionResult modificarAditivo(int id){

            ADAditivo oAditivo = new ADAditivo();
            return View(oAditivo.listarAditivo().Find(adi => adi.Id_Aditivo == id));
        }

        [HttpPost]
        public ActionResult modificarAditivo(int id, Aditivo.Models.Aditivo aditivo){

            ADAditivo oAditivo = new ADAditivo();
            oAditivo.actualizarAditivo(aditivo);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarAditivo(int id){

            try{
                ADAditivo oAditivo = new ADAditivo();
                if (oAditivo.eliminarAditivo(id)){
                    ViewBag.Mensaje = "Registro de Aditivo Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Aditivo";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }
}