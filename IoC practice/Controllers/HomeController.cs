using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IoC_practice.Logger;

namespace IoC_practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyLogger _logger;

        public HomeController(IMyLogger logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            _logger.Info("Hi!");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}