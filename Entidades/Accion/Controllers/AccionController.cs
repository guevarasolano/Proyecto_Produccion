using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class AccionController : Controller{

    public ActionResult Listado(){

        ADAccion oAccion = new ADAccion();
        ModelState.Clear();
        return View(oAccion.listarAccion());
    }

    public ActionResult agregarAccion(Accion.Models.Accion accion){

        try{
            if (ModelState.IsValid){

                ADAccion oAplicacion = new ADAccion();
                if (oAplicacion.insertarAccion(accion)){
                    ViewBag.Menasaje = "Se insertó la Accion correctamente";
                }else{
                    ViewBag.Menasaje = "No se insertó la Accion";
                }

            }
        }catch (Exception ex){
            ex = null;
        }
        return View();
    }

    //get: accion/modificarAccion/5
    public ActionResult modificarAccion(int id){

        ADAccion oAccion = new ADAccion();
        return View(oAccion.listarAccion().Find(acc => acc.Id_Accion == id));
    }

    [HttpPost]
    public ActionResult modificarAccion(int id, Accion.Models.Accion accion){

        ADAccion oAccion = new ADAccion();
        oAccion.actualizarAccion(accion);
        return RedirectToAction("Listado");
    }

    public ActionResult eliminarAccion(int id){

        try{
            ADAccion oAccion = new ADAccion();
            if (oAccion.eliminarAccion(id)){
                ViewBag.Mensaje = "Registro de Accion Eliminado";

                return View();
            }else{
                ViewBag.Mensaje = "Ocurrió un error al Eliminar el Registro de Accion";
            }
            //return RedirectToAction("Listado");
            return RedirectToAction("Listado");
        }catch{

            Console.Write("Hola mundo");
            return RedirectToAction("Listado");

        }
    }

}
