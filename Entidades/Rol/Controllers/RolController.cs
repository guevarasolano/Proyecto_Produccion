using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rol.Controllers{

    public class RolController : Controller{

        public ActionResult Listado(){

            ADRol oRol = new ADRol();
            ModelState.Clear();
            return View(oRol.listarRol());
        }

        public ActionResult agregarRol(Rol.Models.Rol rol){

            try{
                if (ModelState.IsValid){
                    ADRol oRol = new ADRol();
                    if (oRol.insertarRol(rol)){
                        ViewBag.Menasaje = "Se insertó el Rol correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Rol";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: brix/modificarBrix/5
        public ActionResult modificarRol(int id){

            ADRol oRol = new ADRol();
            return View(oRol.listarRol().Find(rol => rol.Id_Rol == id));
        }

        [HttpPost]
        public ActionResult modificarRol(int id, Rol.Models.Rol rol){

            ADRol oRol = new ADRol();
            oRol.actualizarRol(rol);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarRol(int id){

            try{
                ADRol oRol = new ADRol();
                if (oRol.eliminarRol(id)){
                    ViewBag.Mensaje = "Registro de Rol Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Rol";
                }
                return RedirectToAction("Listado");
            }catch{
                return View();
            }
        }

    }
}