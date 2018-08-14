using Modulo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class ModuloController : Controller{

    public ActionResult Listado(){

        ADModulo oModulo = new ADModulo();
        ModelState.Clear();
        return View(oModulo.listarModulo());
    }

    public ActionResult agregarModulo(Modulo.Models.Modulo aplicacion){

        try{
            if (ModelState.IsValid){

               ADModulo oModulo = new ADModulo();
                if (oModulo.insertarModulo(aplicacion)){
                    ViewBag.Menasaje = "Se insertó el Modulo correctamente";
                }else{
                    ViewBag.Menasaje = "No se insertó el Modulo";
                }

            }
        }catch (Exception ex){
            ex = null;
        }
        return View();
    }

    //get: aplicacion/modificarAplicacion/5
    public ActionResult modificarModulo(int id){

        ADModulo oModulo = new ADModulo();
        return View(oModulo.listarModulo().Find(apli => apli.Id_Modulo == id));
    }

    [HttpPost]
    public ActionResult modificarModulo(int id, Modulo.Models.Modulo aplicacion){

        ADModulo oModulo = new ADModulo();
        oModulo.actualizarModulo(aplicacion);
        return RedirectToAction("Listado");
    }

    public ActionResult eliminarModulo(int id){

        try{
            ADModulo oModulo = new ADModulo();
            if (oModulo.eliminarModulo(id)){
                ViewBag.Mensaje = "Registro de Modulo Eliminado";

                return View();
            }else{
                ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Modulo";
            }
            //return RedirectToAction("Listado");
            return RedirectToAction("Listado");
        }catch{

            Console.Write("Hola mundo");
            return RedirectToAction("Listado");

        }
    }

}
