using CapaEntidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class ProductoNoConformeController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADProductoNoConforme oPro = new ADProductoNoConforme();
            ModelState.Clear();
            return View(oPro.listarProductoNoConforme());

        }

        //AGREGAR:
        public ActionResult agregarProductoNoConforme(ProductoNoConforme proceso){

            try{
                if (ModelState.IsValid){

                    ADProductoNoConforme oPro = new ADProductoNoConforme();
                    if (oPro.insertarProductoNoConforme(proceso)){
                        ViewBag.Menasaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Registro";
                    }

                }
            }catch {

            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarProductoNoConforme(int id){

            ADProductoNoConforme oPro = new ADProductoNoConforme();
            return View(oPro.listarProductoNoConforme().Find(pro => pro.Id_Producto_No_Conforme == id));

        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarProductoNoConforme(int id, ProductoNoConforme proceso){

            ADProductoNoConforme oPro = new ADProductoNoConforme();
            oPro.actualizarProductoNoConforme(proceso);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
        public ActionResult eliminarProductoNoConforme(int id){

            try{
                ADProductoNoConforme oPro = new ADProductoNoConforme();
                if (oPro.eliminarProductoNoConforme(id)){
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