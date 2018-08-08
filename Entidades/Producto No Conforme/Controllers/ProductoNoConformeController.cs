using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Producto_No_Conforme.Controllers{

    public class ProductoNoConformeController : Controller{

        public ActionResult Listado(){

            ADProductoNoConforme oPro = new ADProductoNoConforme();
            ModelState.Clear();
            return View(oPro.listarProductoNoConforme());
        }

        public ActionResult agregarProductoNoConforme(Producto_No_Conforme.Models.ProductoNoConforme proceso){

            try{
                if (ModelState.IsValid){

                    ADProductoNoConforme oPro = new ADProductoNoConforme();
                    if (oPro.insertarProductoNoConforme(proceso)){
                        ViewBag.Menasaje = "Se insertó el Registro correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Registro";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: productoNoConforme/modificarProductoNoConforme/5
        public ActionResult modificarProductoNoConforme(int id){

            ADProductoNoConforme oPro = new ADProductoNoConforme();
            return View(oPro.listarProductoNoConforme().Find(pro => pro.Id_Producto_No_Conforme == id));
        }

        [HttpPost]
        public ActionResult modificarProductoNoConforme(int id, Producto_No_Conforme.Models.ProductoNoConforme proceso){

            ADProductoNoConforme oPro = new ADProductoNoConforme();
            oPro.actualizarProductoNoConforme(proceso);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarProductoNoConforme(int id){

            try{
                ADProductoNoConforme oPro = new ADProductoNoConforme();
                if (oPro.eliminarProductoNoConforme(id)){
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