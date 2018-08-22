﻿using CapaEntidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class ProcesoMaduracionController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
            ModelState.Clear();
            return View(oMaduracion.listarProcesoMaduracion());

        }

        //AGREGAR:
        public ActionResult agregarProcesoMaduracion(ProcesoMaduracion maduracion){

            try{
                if (ModelState.IsValid){

                    ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
                    if (oMaduracion.insertarProcesoMaduracion(maduracion)){
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
        public ActionResult modificarProcesoMaduracion(int id){

            ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
            return View(oMaduracion.listarProcesoMaduracion().Find(mad => mad.Id_Proceso_Maduracion == id));

        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarProcesoMaduracion(int id, ProcesoMaduracion maduracion){

            ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
            oMaduracion.actualizarProcesoMaduracion(maduracion);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
        public ActionResult eliminarProcesoMaduracion(int id){

            try{
                ADProcesoMaduracion oMaduracion = new ADProcesoMaduracion();
                if (oMaduracion.eliminarProcesoMaduracion(id)){
                    ViewBag.Mensaje = "Registro Eliminado";
                }else{
                    ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro";
                }
                return RedirectToAction("Listado");
            }catch {

                return View();
            }
        }

    }