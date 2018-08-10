using HotelAtr.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservation.Controllers
{
    public class HomeController : Controller
    {
        public static Model1 db = new Model1();
        public LayoutModel model = new LayoutModel();
        public ActionResult Index()
        {
            return View(model);
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

        public static List<SliderArea> GetSliderArea()
        {
            return db.SliderAreas.ToList();
        }
    }
}