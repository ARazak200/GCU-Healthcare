using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCUHealthcareViewsTest.Controllers
{
    public class PersonalDataController : Controller
    {
        // GET: PersonalData
        public ActionResult Index()
        {
            return View();//landing page
            
        }
        //TODO create a link to index(Home)>>personal data>>(related attribules )
    }
}