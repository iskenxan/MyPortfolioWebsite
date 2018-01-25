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
            DatabaseManager.connectToDatabase();
            ReviewsManager reviewsManager = DataManager.getMyReviews();
            ViewBag.Title = "Reviews";

            return View(reviewsManager);
        }

        [HttpPost]
        public ActionResult Reviews(string reviewerName, string reviewTitle, string reviewComments)
        {
            ReviewsManager reviewsManager = DataManager.getMyReviews();
            Review review = new Review() { Name = reviewerName, ProjectName = reviewTitle, Comment = reviewComments, Date = Formatter.convertDateToHumanString(DateTime.Now),Rating=5 };
            reviewsManager.Reviews.Add(review);
            ViewBag.Title = "Reviews";

            return View(reviewsManager);
        }


        public ActionResult Social()
        {

            ViewBag.Title = "Social";

            return View();
        }
    }
}