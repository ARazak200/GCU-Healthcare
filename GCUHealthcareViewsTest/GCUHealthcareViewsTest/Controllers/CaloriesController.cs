using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCUHealthcareViewsTest.Controllers
{
    public class CaloriesController : Controller
    {
        // GET: Calories
        public ActionResult Index()//showing the current calories 
        {
            return View();
        }
        public ActionResult CAdd()//input the values for adding a calorie intake with date and value
        {
            return View();
        } public ActionResult CDelete()//selecting a list and be able to remove from db and show a confiramtion
        {
            return View();
        }
        public ActionResult CEdit()//selecting a list and be able to edit the selected calorie values 
        {
            return View();
        }
       
    }
}