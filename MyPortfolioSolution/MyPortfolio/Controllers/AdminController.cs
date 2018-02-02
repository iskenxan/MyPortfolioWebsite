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

        public ActionResult Reviews(string newReviewState, int? reviewId)
        {
            if (newReviewState != null)
                modifyReviewState(newReviewState, reviewId);

            ReviewsManager reviewsManager = DataManager.getMyReviews(false);

            ViewBag.Title = "Admin Reviews";

            return View(reviewsManager);
        }


        private void modifyReviewState(string newState, int? reviewId)
        {
            int id = (int)reviewId;
            if (newState=="Accept")
                DatabaseManager.updateRecord(DatabaseManager.REVIEWS_TABLE, id, DatabaseManager.REVIEW_APPROVED, true);
            else
                DatabaseManager.removeRecord(DatabaseManager.REVIEWS_TABLE, id);
        }


        public ActionResult Projects()
        {
            ProjectListManager projects = DataManager.getMyProjectListManager();

            ViewBag.Title = "Admin Projects";

            return View(projects);
        }


        public ActionResult Skills()
        {
            List<string> languages = DataManager.getKnownLanguages();
            List<string> technologies = DataManager.getKnowTechnologies();

            ViewBag.Title = "Admin Skills";
            ViewBag.languages = languages;
            ViewBag.technologies = technologies;

            return View();
        }
    }
}