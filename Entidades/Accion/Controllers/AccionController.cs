using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class AccionController : Controller{
    
    //LISTADO:
    public ActionResult Listado(){

        ADAccion oAccion = new ADAccion();
        ModelState.Clear();
        return View(oAccion.listarAccion());
    }

    //AGREGAR:
    public ActionResult agregarAccion(Accion.Models.Accion accion){

        try{
            if (ModelState.IsValid){

                ADAccion oAplicacion = new ADAccion();
                if (oAplicacion.insertarAccion(accion)){
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
    public ActionResult modificarAccion(int id){

        ADAccion oAccion = new ADAccion();
        return View(oAccion.listarAccion().Find(acc => acc.Id_Accion == id));
    }

    //MODIFICAR:
    [HttpPost]
    public ActionResult modificarAccion(int id, Accion.Models.Accion accion){

        ADAccion oAccion = new ADAccion();
        oAccion.actualizarAccion(accion);
        return RedirectToAction("Listado");
    }

    //ELIMINAR:
    public ActionResult eliminarAccion(int id){

        try{
            ADAccion oAccion = new ADAccion();
            if (oAccion.eliminarAccion(id)){
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
