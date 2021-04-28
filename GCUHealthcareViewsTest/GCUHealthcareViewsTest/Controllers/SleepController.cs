using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCUHealthcareViewsTest.Controllers
{
    public class SleepController : Controller
    {
        // GET: Sleep
        public ActionResult Index()
        {
            return View();
        }

        // TODO will need to update with count.cshtml
        public ActionResult SAdd()//input the values for adding amount of sleep with hours.
        {
            return View();
        }

        public ActionResult SDelete()//selecting a list and be able to remove from db and show a confiramtion
        {
            return View();
        }

        public ActionResult SEdit()//selecting a list and be able to edit the selected sleep values 
        {
            return View();
        }
    }
}