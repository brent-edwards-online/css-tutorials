using CustomBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomBootstrap.Controllers
{
    public class BootstrapController : Controller
    {

        private NavigationViewModel nav = new NavigationViewModel();

        public ActionResult Index()
        {            
            return View(nav);
        }

        public ActionResult ParkInfo()
        {
            return View("ParkInfo", nav);
        }

        public ActionResult Attractions()
        {
            return View("Attractions", nav);
        }

        public ActionResult GroupEvents()
        {
            return View("GroupEvents", nav);
        }

    }
}