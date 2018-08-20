using Proceso_Llenado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class ProcesoLlenadoController : Controller{

    //LISTAR:
    public ActionResult Listado(){

        ADProcesoLlenado oLlenado = new ADProcesoLlenado();
        ModelState.Clear();
        return View(oLlenado.listarProcesoLlenado());

    }

    //AGREGAR:
    public ActionResult agregarProcesoLlenado(ProcesoLlenado llenado){

        try{
            if (ModelState.IsValid){

                ADProcesoLlenado oLlenado = new ADProcesoLlenado();
                if (oLlenado.insertarProcesoLlenado(llenado)){
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
    public ActionResult modificarProcesoLlenado(int id){

        ADProcesoLlenado oLlenado = new ADProcesoLlenado();
        return View(oLlenado.listarProcesoLlenado().Find(dis => dis.Id_Proceso_Llenado == id));
    }

    //MODIFICAR:
    [HttpPost]
    public ActionResult modificarProcesoLlenado(int id, ProcesoLlenado llenado){

        ADProcesoLlenado oLlenado = new ADProcesoLlenado();
        oLlenado.actualizarProcesoLlenado(llenado);
        return RedirectToAction("Listado");

    }

    //ELIMINAR:
    public ActionResult eliminarProcesoLlenado(int id){

        try{
            ADProcesoLlenado oLlenado = new ADProcesoLlenado();
            if (oLlenado.eliminarProcesoLlenado(id)){
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
