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



        [HttpPost]
        public ActionResult Reviews(string reviewerName, string reviewTitle, string reviewComments, string rating)
        {
            int ratingInt = Int32.Parse(rating);
            Review review = DataConverter.generateReview(reviewerName, reviewTitle, reviewComments, ratingInt);
            string result=DatabaseManager.writeReviewToDatabase(review);
            if (result != "success")
                ViewBag.Error = result;
            ReviewsManager reviewsManager = DataManager.getMyReviews();
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