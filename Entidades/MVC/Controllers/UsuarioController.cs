using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccesoDatos;
using CapaEntidades;

public class UsuarioController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADUsuario oUsuario = new ADUsuario();
            ModelState.Clear();
            return View(oUsuario.listarUsuario());
        }

        //AGREGAR:
        public ActionResult agregarUsuario(Usuario usuario){

            try{
                if (ModelState.IsValid){

                    ADUsuario oUsuario = new ADUsuario();
                    if (oUsuario.insertarUsuario(usuario)){
                        ViewBag.Mensaje = "Se insertó el Registro Correctamente";
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
        public ActionResult modificarUsuario(int id){

            ADUsuario oUsuario = new ADUsuario();
            return View(oUsuario.listarUsuario().Find(usu => usu.Id_Usuario == id));

        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarUsuario(int id, Usuario usuario){

            ADUsuario oUsuario = new ADUsuario();
            oUsuario.actualizarUsuario(usuario);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
        public ActionResult eliminarUsuario(int id){

            try{
                ADUsuario oUsuario = new ADUsuario();
                if (oUsuario.eliminarUsuario(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }
                else{
                    ViewBag.Mensaje = "No se insertó el Registro";
                }
                return RedirectToAction("Listado");
            }
            catch{
                return View();
            }
        }

    }