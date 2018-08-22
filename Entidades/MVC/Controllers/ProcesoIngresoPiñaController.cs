using AccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class ProcesoIngresoPiñaController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
            ModelState.Clear();
            return View(oIngreso.listarProcesoIngresoPiña());
        }

        //AGREGAR:
        public ActionResult agregarProcesoIngresoPiña(ProcesoIngresoPiña ingreso){

            try{
                if (ModelState.IsValid){
                    ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
                    if (oIngreso.insertarProcesoIngresoPiña(ingreso)){
                        ViewBag.Mensaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el registro";
                    }

                }
            }catch {

            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarProcesoIngresoPiña(int id){

            ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
            return View(oIngreso.listarProcesoIngresoPiña().Find(piñ => piñ.Id_Proceso_Ingreso_Piña == id));
        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarProcesoIngresoPiña(int id, ProcesoIngresoPiña ingreso){

            ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
            oIngreso.actualizarProcesoIngresoPiña(ingreso);
            return RedirectToAction("Listado");
        }

        //ELIMINAR:
        public ActionResult eliminarProcesoIngresoPiña(int id){

            try{
                ADProcesoIngresoPiña oIngreso = new ADProcesoIngresoPiña();
                if (oIngreso.eliminarProcesoIngresoPiña(id)){
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