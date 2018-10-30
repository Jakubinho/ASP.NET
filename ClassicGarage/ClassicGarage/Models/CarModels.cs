using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class CarModels
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int VIN { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchaseAmount { get; set; }
        public DateTime SalesDate { get; set; }
        public double SalesAmount { get; set; }
        public int OwnerID { get; set; }
        
        public virtual OwnerModel Owner { get; set; }
    }
}