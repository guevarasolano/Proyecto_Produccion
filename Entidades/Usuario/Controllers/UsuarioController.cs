using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Usuario.Controllers{

    public class UsuarioController : Controller{

        public ActionResult Listado(){

            ADUsuario oUsuario = new ADUsuario();
            ModelState.Clear();
            return View(oUsuario.listarUsuario());
        }

        public ActionResult agregarAplicacion(Usuario.Models.Usuario usuario){

            try{
                if (ModelState.IsValid){

                    ADUsuario oAplicacion = new ADUsuario();
                    if (oAplicacion.insertarUsuario(usuario)){
                        ViewBag.Menasaje = "Se insertó la usuario correctamente";
                    }
                    else{
                        ViewBag.Menasaje = "No se insertó la usuario";
                    }

                }
            }
            catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: aplicacion/modificarAplicacion/5
        public ActionResult modificarUsuario(int id){

            ADUsuario oUsuario = new ADUsuario();
            return View(oUsuario.listarUsuario().Find(usu => usu.Id_Usuario == id));
        }

        [HttpPost]
        public ActionResult modificarUsuario(int id, Usuario.Models.Usuario usuario){

            ADUsuario oUsuario = new ADUsuario();
            oUsuario.actualizarUsuario(usuario);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarUsuario(int id){

            try{
                ADUsuario oAplicacion = new ADUsuario();
                if (oAplicacion.eliminarUsuario(id)){
                    ViewBag.Mensaje = "Registro de Usuario Eliminado";
                }
                else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Usuario";
                }
                return RedirectToAction("Listado");
            }
            catch{
                return View();
            }
        }

    }
}