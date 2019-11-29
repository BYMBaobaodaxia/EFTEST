using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.FilterExtend;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [AuthorizeExtend]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        [HandleError]
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