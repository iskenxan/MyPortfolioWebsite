﻿using System;
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
    }
}