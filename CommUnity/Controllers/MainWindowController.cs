using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommUnity.Controllers
{
    public class MainWindowController : Controller
    {
        public ActionResult Index()
        {   

            return View("MainWindow");
        }
    }
}