using SAP_Produccion_Info.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class SAPProduccionInfoController : Controller{

        //LISTAR:
        public ActionResult Listado(){

            ADSAPProduccionInfo oSAP = new ADSAPProduccionInfo();
            ModelState.Clear();
            return View(oSAP.listarSAPProduccionInfo());

        }

        //AGREGAR:
        public ActionResult agregarSAPProduccionInfo(SAP_Produccion_Info.Models.SAPProduccionInfo sap){

            try{
                if (ModelState.IsValid){

                    ADSAPProduccionInfo oSAP = new ADSAPProduccionInfo();
                    if (oSAP.insertarSAPProduccionInfo(sap)){
                        ViewBag.Mensaje = "Se insertó el Registro Correctamente";
                    }else{
                        ViewBag.Mensaje = "No se insertó el Registro";
                    }

                }
            }catch {

            }
            return View();
        }

        //MODIFICAR:
        public ActionResult modificarSAPProduccionInfo(int id){

            ADSAPProduccionInfo oSAP = new ADSAPProduccionInfo();
            return View(oSAP.listarSAPProduccionInfo().Find(sap => sap.Id_SAP_Produccion_Info == id));

        }

        //MODIFICAR:
        [HttpPost]
        public ActionResult modificarSAPProduccionInfo(int id, SAP_Produccion_Info.Models.SAPProduccionInfo sap){

            ADSAPProduccionInfo oSAP = new ADSAPProduccionInfo();
            oSAP.actualizarSAPProduccionInfo(sap);
            return RedirectToAction("Listado");

        }

        //ELIMINAR:
        public ActionResult eliminarSAPProduccionInfo(int id){

            try{
                ADSAPProduccionInfo oSAP = new ADSAPProduccionInfo();
                if (oSAP.eliminarSAPProduccionInfo(id)){
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