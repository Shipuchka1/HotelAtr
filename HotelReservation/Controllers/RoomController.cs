using HotelAtr.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservation.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public LayoutModel model = new LayoutModel();
        public ActionResult Index()
        {
            return View(model);
        }
    }
}