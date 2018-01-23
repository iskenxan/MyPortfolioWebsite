using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        public ActionResult Panel()
        {
            ViewBag.Title = "Admin Panel";

            return View();
        }

        public ActionResult Reviews()
        {
            ReviewsManager reviewsManager = DataManager.getMyReviews();

            ViewBag.Title = "Admin Reviews";

            return View(reviewsManager);
        }


        public ActionResult Projects()
        {
            ProjectListManager projects = DataManager.getMyProjectListManager();

            ViewBag.Title = "Admin Projects";

            return View(projects);
        }
    }
}