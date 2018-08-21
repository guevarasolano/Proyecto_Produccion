using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccesoDatos;
using CapaEntidades;

    public class AplicacionController : Controller{
        
        //LISTAR:
        public ActionResult Listado(){

            ADAplicacion oAplicacion = new ADAplicacion();
            ModelState.Clear();
            return View(oAplicacion.listarAplicacion());
        }
        
        //AGREGAR:
        public ActionResult agregarAplicacion(Aplicacion aplicacion){

            try{
                if (ModelState.IsValid){

                    ADAplicacion oAplicacion = new ADAplicacion();
                    if (oAplicacion.insertarAplicacion(aplicacion)){
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
        public ActionResult modificarAplicacion(int id){

            ADAplicacion oAplicacion = new ADAplicacion();
            return View(oAplicacion.listarAplicacion().Find(apli => apli.Id_Aplicacion == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarAplicacion(int id, Aplicacion aplicacion){

            ADAplicacion oAplicacion = new ADAplicacion();
            oAplicacion.actualizarAplicacion(aplicacion);
            return RedirectToAction("Listado");
        }

        //ELIMINAR:
        public ActionResult eliminarAplicacion(int id){

            try{
                ADAplicacion oAplicacion = new ADAplicacion();
                if (oAplicacion.eliminarAplicacion(id)){
                    ViewBag.Mensaje = "Registro Eliminado";

                    return View();

                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro";
                }

               return RedirectToAction("Listado");

            }catch{

                return View();
            }
        }

    }