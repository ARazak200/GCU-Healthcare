﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCUHealthcareViewsTest.Controllers
{
    public class CaloriesController : Controller
    {
        // GET: Calories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CAdd()
        {
            return View();
        }
    }
}