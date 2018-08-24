using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers{

    public class MenuController : Controller{

        public ActionResult Menu(){
            return View("~/Views/Menu/Menu.cshtml");
        }


    }
}