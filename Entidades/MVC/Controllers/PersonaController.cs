using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using AccesoDatos;

namespace MVC.Controllers{

    public class PersonaController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADPersona oPersona = new ADPersona();
            ModelState.Clear();
            return View(oPersona.listarPersona());

        }

        //AGREGAR:
        public ActionResult agregarPersona(Persona persona){

            try{
                if (ModelState.IsValid){
                    ADPersona oPersona = new ADPersona();
                    if (oPersona.insertarPersona(persona)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }catch{

            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarPersona(int id){

            ADPersona oPersona = new ADPersona();
            return View(oPersona.listarPersona().Find(per => per.Id_Persona == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarPersona(int id, Persona persona){

            ADPersona oPersona = new ADPersona();
            oPersona.actualizarPersona(persona);
            return RedirectToAction("Listado");
        }

        //ELIMINAR:
        public ActionResult eliminarPersona(int id){

            try{
                ADPersona oPersona = new ADPersona();
                if (oPersona.eliminarPersona(id)){
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
}