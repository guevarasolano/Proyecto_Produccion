using Distribucion_Inventario_Tanque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class DistribucionInventarioTanqueController : Controller{

    //LISTAR:
    public ActionResult Listado(){

        ADDistribucionInventarioTanque oDistribucion = new ADDistribucionInventarioTanque();
        ModelState.Clear();
        return View(oDistribucion.listarDistribucionInventarioTanque());

    }

    //AGREGAR:
    public ActionResult agregarDistribucionInventarioTanque(DistribucionInventarioTanque distribucion){

        try{
            if (ModelState.IsValid){

                ADDistribucionInventarioTanque oDistribucion = new ADDistribucionInventarioTanque();
                if (oDistribucion.insertarDistribucionInventarioTanque(distribucion)){
                    ViewBag.Mensaje = "Se insertó el Registro correctamente";
                }else{
                    ViewBag.Mensaje = "No se insertó el Registro";
                }

            }
        }catch (Exception ex){
            ex = null;
        }
        return View();
    }

    //MODIFICAR:
    public ActionResult modificarDistribucionInventarioTanque(int id){

        ADDistribucionInventarioTanque oDistribucion = new ADDistribucionInventarioTanque();
        return View(oDistribucion.listarDistribucionInventarioTanque().Find(dis => dis.Id_Distribucion_Inventario_Tanque == id));

    }

    //MODIFICAR:
    [HttpPost]
    public ActionResult modificarInDistribucionInventarioTanque(int id, DistribucionInventarioTanque distribucion){

        ADDistribucionInventarioTanque oDistribucion = new ADDistribucionInventarioTanque();
        oDistribucion.actualizarDistribucionInventarioTanque(distribucion);
        return RedirectToAction("Listado");
    }

    //ELIMINAR:
    public ActionResult eliminarDistribucionInventarioTanque(int id){

        try{
            ADDistribucionInventarioTanque oDistribucion = new ADDistribucionInventarioTanque();
            if (oDistribucion.eliminarDistribucionInventarioTanque(id)){
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
