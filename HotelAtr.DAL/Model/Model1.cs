namespace HotelAtr.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<SliderArea> SliderAreas { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .Property(e => e.Square)
                .HasPrecision(18, 0);
        }
    }
}
