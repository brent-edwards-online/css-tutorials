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
        // GET: Bootstrap
        public ActionResult Index()
        {
            var nav = new NavigationViewModel();
            return View(nav);
        }
    }
}