using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelAtr.DAL.Model;

namespace HotelReservation.Controllers
{
    public class AreaController : Controller
    {
        public Model1 db = new Model1();
        // GET: Area
        public ActionResult Index()
        {
            return View(db.SliderAreas.ToList());
        }

        public ActionResult AddSlide(SliderArea sliderArea)
        {
            ServiceArea.AddSlider(sliderArea);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSlider(int id)
        {
            ServiceArea.DeleteSlider(id);
            return RedirectToAction("Index");
        }

    }
}