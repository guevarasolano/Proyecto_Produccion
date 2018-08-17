using Modulo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class ModuloController : Controller{

    //LISTAR:
    public ActionResult Listado(){

        ADModulo oModulo = new ADModulo();
        ModelState.Clear();
        return View(oModulo.listarModulo());
    }

    //AGREGAR:
    public ActionResult agregarModulo(Modulo.Models.Modulo modulo){

        try{
            if (ModelState.IsValid){

               ADModulo oModulo = new ADModulo();
                if (oModulo.insertarModulo(modulo)){
                    ViewBag.Mensaje = "Se insertó el Registro correctamente";
                }else{
                    ViewBag.Mensaje = "No se insertó el Modulo";
                }

            }
        }catch {

        }
        return View();
    }

    //MODIFICAR:
    public ActionResult modificarModulo(int id){

        ADModulo oModulo = new ADModulo();
        return View(oModulo.listarModulo().Find(mod => mod.Id_Modulo == id));
    }

    //MODIFICAR:
    [HttpPost]
    public ActionResult modificarModulo(int id, Modulo.Models.Modulo modulo){

        ADModulo oModulo = new ADModulo();
        oModulo.actualizarModulo(modulo);
        return RedirectToAction("Listado");
    }

    //ELIMINAR:
    public ActionResult eliminarModulo(int id){

        try{
            ADModulo oModulo = new ADModulo();
            if (oModulo.eliminarModulo(id)){
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
