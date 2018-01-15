using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NavbarManager navManager = new NavbarManager("About");
            List<string> languages = DataManager.getKnownLanguages();
            List<string> technologies = DataManager.getKnowTechnologies();

            ViewBag.languages = languages;
            ViewBag.technologies = technologies;

            return View(navManager);
        }


        public ActionResult Projects()
        {
            NavbarManager navManager = new NavbarManager("Projects");

            ViewBag.Message = "Your application description page.";

            return View(navManager);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}