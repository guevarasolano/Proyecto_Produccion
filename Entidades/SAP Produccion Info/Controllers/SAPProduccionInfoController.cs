using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAP_Produccion_Info.Controllers{

    public class SAPProduccionInfoController : Controller{

        public ActionResult Listado(){

            Models.ADSAPProduccionInfo oSAP = new Models.ADSAPProduccionInfo();
            ModelState.Clear();
            return View(oSAP.listarSAPProduccionInfo());
        }

        public ActionResult agregarSAPProduccionInfo(SAP_Produccion_Info.Models.SAPProduccionInfo sap){

            try{
                if (ModelState.IsValid){

                    Models.ADSAPProduccionInfo oSAP = new Models.ADSAPProduccionInfo();
                    if (oSAP.insertarSAPProduccionInfo(sap)){
                        ViewBag.Menasaje = "Se insertó el Registro Correctamente";
                    }else{
                        ViewBag.Menasaje = "No se insertó el Registro";
                    }

                }
            }catch (Exception ex){
                ex = null;
            }
            return View();
        }

        //get: SAPProduccionInfo/modificarSAPProduccionInfo/5
        public ActionResult modificarSAPProduccionInfo(int id){

            Models.ADSAPProduccionInfo oSAP = new Models.ADSAPProduccionInfo();
            return View(oSAP.listarSAPProduccionInfo().Find(sap => sap.Id_SAP_Produccion_Info == id));
        }

        [HttpPost]
        public ActionResult modificarSAPProduccionInfo(int id, SAP_Produccion_Info.Models.SAPProduccionInfo sap){

            Models.ADSAPProduccionInfo oSAP = new Models.ADSAPProduccionInfo();
            oSAP.actualizarSAPProduccionInfo(sap);
            return RedirectToAction("Listado");
        }

        public ActionResult eliminarSAPProduccionInfo(int id){

            try{
                Models.ADSAPProduccionInfo oSAP = new Models.ADSAPProduccionInfo();
                if (oSAP.eliminarSAPProduccionInfo(id)){
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