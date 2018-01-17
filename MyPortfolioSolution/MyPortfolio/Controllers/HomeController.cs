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
            List<string> languages = DataManager.getKnownLanguages();
            List<string> technologies = DataManager.getKnowTechnologies();

            ViewBag.languages = languages;
            ViewBag.technologies = technologies;

            return View();
        }


        public ActionResult Projects()
        {
            ViewBag.Title = "Projects";

            ProjectListManager projectManager = DataManager.getMyProjectListManager();


            return View(projectManager);
        }


        public ActionResult Reviews()
        {
            ReviewsManager reviewsManager = DataManager.getMyReviews();

            ViewBag.Title = "Reviews";

            return View(reviewsManager);
        }
    }
}