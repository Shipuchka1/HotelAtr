using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAtr.DAL.Model
{
    public class LayoutModel
    {
        private HotelAtr.DAL.Model.Model1 db = new Model1();
        public List<Room> rooms = new List<Room>();
        public List<RoomType> roomTypes = new List<RoomType>();
        public List<SliderArea> sliders = new List<SliderArea>();
        public List<Service> services = new List<Service>();
        public LayoutModel()
        {
            rooms = db.Rooms.ToList();
            sliders = db.SliderAreas.ToList();
            roomTypes = db.RoomTypes.ToList();
            services = db.Services.ToList();
        }
    }
}
