using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kosorus_Arpad_Hotel.Model;

namespace Kosorus_Arpad_Hotel.Data
{
    public class Kosorus_Arpad_HotelContext : DbContext
    {
        public Kosorus_Arpad_HotelContext (DbContextOptions<Kosorus_Arpad_HotelContext> options)
            : base(options)
        {
        }
        public DbSet<Kosorus_Arpad_Hotel.Model.PetModel> PetModel { get; set; }
        public DbSet<Kosorus_Arpad_Hotel.Model.OwnerModel> OwnerModel { get; set; }
        public DbSet<Kosorus_Arpad_Hotel.Model.RoomModel> RoomModel { get; set; }

    }
}
