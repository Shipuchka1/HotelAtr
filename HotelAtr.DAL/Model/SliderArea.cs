namespace HotelAtr.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SliderArea")]
    public partial class SliderArea
    {
        public int SliderAreaId { get; set; }

        [Required]
        [StringLength(250)]
        public string Header { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string URL { get; set; }

        [StringLength(250)]
        public string PathImg { get; set; }
    }
}
