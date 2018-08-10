using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelAtr.DAL.Model;

namespace Hotel.Atr.Admin.Controllers
{
    public class AreaController : Controller
    {
        public Model1 db = new Model1();
        // GET: Area
        public ActionResult Index()
        {
            return View(db.SliderAreas.ToList());
        }

        public ActionResult AddSlide(SliderArea sliderArea, int id = 0)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {        
                        if(ServiceArea.AddSlider(sliderArea))
                        return RedirectToAction("Index");                  
                }
                else
                {
                    ServiceArea.UpdateSlider(sliderArea, id);
                    return RedirectToAction("Index");
                }
            }
            if (id != 0)
            {
                SliderArea temp = db.SliderAreas.FirstOrDefault(f => f.SliderAreaId == id);
                return View(temp);
            }
            return View();       
    }

        public ActionResult DeleteSlider(int id)
        {
            ServiceArea.DeleteSlider(id);
            return RedirectToAction("Index");
        }

        public ActionResult ViewServices()
        {
            return View(db.Services.ToList());
        }

        public ActionResult AddService(Service service, int id = 0)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    if (ServiceArea.AddService(service))
                        return RedirectToAction("ViewServices");
                }
                else
                {
                    ServiceArea.UpdateService(service, id);
                    return RedirectToAction("ViewServices");
                }
            }
            if (id != 0)
            {
                Service temp = db.Services.FirstOrDefault(f => f.ServiceId == id);
                return View(temp);
            }
            return View();
        }

        public ActionResult DeleteService(int id)
        {
            ServiceArea.DeleteService(id);
            return RedirectToAction("ViewServices");
        }

    }
}