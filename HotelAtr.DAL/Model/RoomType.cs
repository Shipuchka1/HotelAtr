namespace HotelAtr.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomType")]
    public partial class RoomType
    {
        public int RoomTypeId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        
        public decimal Cost { get; set; }

        [StringLength(250)]
        public string PathImg { get; set; }

        public bool IsFreeWiFi { get; set; }

        public bool isPrivateBalcony { get; set; }

        public bool isFullAC { get; set; }

        public bool HasTV { get; set; }

        public bool isBeachView { get; set; }

    }
}
