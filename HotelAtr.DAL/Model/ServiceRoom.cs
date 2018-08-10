using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAtr.DAL.Model
{
    public class ServiceRoom
    {
        private static Model1 db = new Model1();
        public static bool AddRoom(Room room)
        {
            
            try
            {
                db.Rooms.Add(room);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        public static bool DeleteRoom(int roomId)
        {
            try
            {
                Room room = db.Rooms.Find(roomId);
                if (room != null)
                    db.Rooms.Remove(room);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool SaveRoom(Room room)
        {
            Room temp = db.Rooms.Find(room.RoomId);
            try
            {
              
                db.Entry(temp).CurrentValues.SetValues(room);
                db.SaveChanges();
                return true;
               
            }
            catch
            {
                return false;
            }
        }

        public static bool AddRoomType(RoomType roomType, int id = 0)
        {
            if(id == 0)
            {
                try
                {
                    db.RoomTypes.Add(roomType);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                roomType = db.RoomTypes.First(f => f.RoomTypeId == id);
                db.Entry(roomType).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            
        }

        public static bool RoomTypeDelete(int id)
        {
            RoomType room = db.RoomTypes.FirstOrDefault(f => f.RoomTypeId == id);
            try
            {
                db.RoomTypes.Remove(room);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
