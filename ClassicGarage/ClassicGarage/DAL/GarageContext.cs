using ClassicGarage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClassicGarage.DAL
{
    public class GarageContext : DbContext
    {
        public DbSet<CarModels> Car { get; set; }

        public DbSet<OwnerModel> Owner { get; set; }
    }
}