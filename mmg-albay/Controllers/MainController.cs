using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmg_albay.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Tabaco()
        {
            return View("Tabaco");
        }


        public ActionResult Legazpi()
        {
            return View("Legazpi");
        }


        public ActionResult Ligao()
        {
            return View("Ligao");
        }


        public ActionResult Polangui()
        {
            return View("Polangui");
        }

    }
}
