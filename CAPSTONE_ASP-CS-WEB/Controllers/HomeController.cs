using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CAPSTONE_ASP_CS_WEB.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
