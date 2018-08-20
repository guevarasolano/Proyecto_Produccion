using Rol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class RolController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADRol oRol = new ADRol();
            ModelState.Clear();
            return View(oRol.listarRol());

        }

        //AGREGAR:
        public ActionResult agregarRol(Rol.Models.Rol rol){

            try{
                if (ModelState.IsValid){
                    ADRol oRol = new ADRol();
                    if (oRol.insertarRol(rol)){
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
        public ActionResult modificarRol(int id){

            ADRol oRol = new ADRol();
            return View(oRol.listarRol().Find(rol => rol.Id_Rol == id));

        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarRol(int id, Rol.Models.Rol rol){

            ADRol oRol = new ADRol();
            oRol.actualizarRol(rol);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
        public ActionResult eliminarRol(int id){

            try{
                ADRol oRol = new ADRol();
                if (oRol.eliminarRol(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "No se insertó el Registro";
                }

                return RedirectToAction("Listado");
            }catch {

                return View();
            }
        }

    }