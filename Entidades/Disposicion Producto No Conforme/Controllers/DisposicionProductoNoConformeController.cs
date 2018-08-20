using Disposicion_Producto_No_Conforme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class DisposicionProductoNoConformeController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
            ModelState.Clear();
            return View(oDisposicion.listarDisposicionProductoNoConforme());
        }

        //AGREGAR:
        public ActionResult agregarDisposicionProductoNoConforme(Disposicion_Producto_No_Conforme.Models.DisposicionProductoNoConforme disposicion){

            try{
                if (ModelState.IsValid){

                    ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
                    if (oDisposicion.insertarDisposicionProductoNoConforme(disposicion)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarDisposicionProductoNoConforme(int id){

            ADDisposicionProductoNoConforme oUsuario = new ADDisposicionProductoNoConforme();
            return View(oUsuario.listarDisposicionProductoNoConforme().Find(dis => dis.Id_Disposicion_Producto_No_Conforme == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarDisposicionProductoNoConforme(int id, Disposicion_Producto_No_Conforme.Models.DisposicionProductoNoConforme disposicion){

            ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
            oDisposicion.actualizarDisposicionProductoNoConforme(disposicion);
            return RedirectToAction("Listado");
        }

        //ELIMINAR:
        public ActionResult eliminarDisposicionProductoNoConforme(int id){

            try{
                ADDisposicionProductoNoConforme oDisposicion = new ADDisposicionProductoNoConforme();
                if (oDisposicion.eliminarDisposicionProductoNoConforme(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "No se insertó el Registro";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }