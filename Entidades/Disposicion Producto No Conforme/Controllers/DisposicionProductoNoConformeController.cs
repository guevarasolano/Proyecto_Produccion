using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Disposicion_Producto_No_Conforme.Controllers{

    public class DisposicionProductoNoConformeController : Controller{

        public ActionResult Listado(){

            ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
            ModelState.Clear();
            return View(oDisposicion.listarDisposicionProductoNoConforme());
        }

        public ActionResult agregarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme.Models.DisposicionProductoNoConforme disposicion){

            try{
                if (ModelState.IsValid){

                    ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
                    if (oDisposicion.insertarDisposicionProductoNoConforme(disposicion)){
                        ViewBag.Menasaje = "Se insertó el usuario correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el usuario";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: disposicionProductoNoConforme/modificarDisposicionProductoNoConforme/5
        public ActionResult modificarDisposicionProductoNoConforme(int id){

            ADDisposicionProductoNoConforme oUsuario = new ADDisposicionProductoNoConforme();
            return View(oUsuario.listarDisposicionProductoNoConforme().Find(dis => dis.Id_Disposicion_Producto_No_Conforme == id));
        }

        [HttpPost]
        public ActionResult modificarDisposicionProductoNoConforme(int id, Disposicion_Producto_No_Conforme.Models.DisposicionProductoNoConforme disposicion){

            ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
            oDisposicion.actualizarDisposicionProductoNoConforme(disposicion);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarDisposicionProductoNoConforme(int id){

            try{
                ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
                if (oDisposicion.eliminarDisposicionProductoNoConforme(id)){
                    ViewBag.Mensaje = "Registro de Usuario Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Usuario";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }
}