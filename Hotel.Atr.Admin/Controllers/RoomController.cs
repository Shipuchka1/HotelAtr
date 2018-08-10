using HotelAtr.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Atr.Admin.Controllers
{
    public class RoomController : BaseController
    {
        LayoutModel layoutModel = new LayoutModel();
        // GET: Room
        public ActionResult Index()
        {
            return View(layoutModel.rooms);
        }

        public ActionResult AddRoom(Room room, string action, int statusCode = -1, int roomId = 0)
        {
            
                ViewBag.RoomTypeList = db.RoomTypes.Select(s => new SelectListItem() { Text = s.Name, Value = s.RoomTypeId.ToString() }).ToList();
            if (room.RoomId == 0 && action == "Add")
            {
               
                if (ServiceRoom.AddRoom(room))
                {
                    return RedirectToAction("Index");
                }
            }

            if(action == "Save")
            {
                
                if (ServiceRoom.SaveRoom(room))
                   return  RedirectToAction("Index");
            }

            else if (room.RoomId != 0 && roomId!=0)
            {
                room = db.Rooms.Find(roomId);
                return View(room);
            }
            ViewBag.StatusCode = 1;


            return View();
        }


        public ActionResult Delete(int roomId)
        {
            ServiceRoom.DeleteRoom(roomId);
            return RedirectToAction("Index");
        }

        public ActionResult AddRoomType(RoomType roomType, string action="", int id = 0 )
        {

            if (id == 0 && action == "Add")
            {
                ServiceRoom.AddRoomType(roomType, id);
                return View();
            }

            else if (id != 0 && action == "Save")
            {
                RoomType temp = db.RoomTypes.FirstOrDefault(f => f.RoomTypeId == id);
                roomType.RoomTypeId = id;
                db.Entry(temp).CurrentValues.SetValues(roomType);
                db.SaveChanges();
                return View(roomType);
            }

            else if (id != 0)
            {
                return View(db.RoomTypes.FirstOrDefault(f => f.RoomTypeId == id));
            }
            else return View();
        }

        public ActionResult RoomTypeIndex()
        {
            
            return View(db.RoomTypes.ToList());
        }

        public ActionResult RoomTypeDelete(int id)
        {
            ServiceRoom.RoomTypeDelete(id);
            return RedirectToAction("RoomTypeIndex");           
        }
    }
}