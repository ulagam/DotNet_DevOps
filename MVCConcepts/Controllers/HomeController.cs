using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCConcepts.UtilityFilter;

namespace MVCConcepts.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/      
        [CustomActionFilter]
        public ActionResult Index()
        {
            return View();
        }

    }
}
