using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCMasterPageNewbit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ok
            return RedirectToAction("../TrangChu");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}