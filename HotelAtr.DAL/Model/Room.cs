namespace HotelAtr.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        public int RoomId { get; set; }
        
        public int RoomTypeId { get; set; }

        public RoomType RoomType { get; set; }

        public decimal Square { get; set; }

        public int CountOfPerson { get; set; }

        public int Floor { get; set; }

       
    }
}
