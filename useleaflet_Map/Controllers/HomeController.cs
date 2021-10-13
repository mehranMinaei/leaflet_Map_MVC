using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace useleaflet_Map.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<VM.orderListVM> orders_ = new List<VM.orderListVM>();
            VM.orderListVM order = null;
            order = new VM.orderListVM("Driver Name", "DrivePhone", "DriveImagePath", "Description", Convert.ToDouble(52.480783),
                  Convert.ToDouble(-1.904096), Convert.ToDouble(52.473098), Convert.ToDouble(-1.900923), Convert.ToDouble(52.475086),
                  Convert.ToDouble(-1.903097), 1,
                  1, "1", 1, "user Name ",0,
                  "ShopName", "CustomerName");
            orders_.Add(order);
            return View(order);
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