using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAtr.DAL.Model
{
   public class ServiceArea
    {
        public static Model1 db = new Model1();
        public static bool AddSlider(SliderArea sliderArea)
        {
            try
            {
                db.SliderAreas.Add(sliderArea);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateSlider(SliderArea sliderArea, int id)
        {
            try
            {
                SliderArea temp = db.SliderAreas.FirstOrDefault(f => f.SliderAreaId == id);
                sliderArea.SliderAreaId = id;
                db.Entry(temp).CurrentValues.SetValues(sliderArea);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteSlider(int id)
        {
            try
            {
                SliderArea temp = db.SliderAreas.FirstOrDefault(f => f.SliderAreaId == id);
                db.SliderAreas.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddService(Service service)
        {
            try
            {
                db.Services.Add(service);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateService(Service service, int id)
        {
            try
            {
                Service temp = db.Services.FirstOrDefault(f => f.ServiceId == id);
                service.ServiceId = id;
                db.Entry(temp).CurrentValues.SetValues(service);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteService(int id)
        {
            try
            {
                Service temp = db.Services.FirstOrDefault(f => f.ServiceId == id);
                db.Services.Remove(temp);
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
