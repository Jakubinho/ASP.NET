using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassicGarage.Models
{
    public class CarPartsModels
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public string Name { get; set; }
        public int CatalogNr { get; set; }
        public double PurchasePrice { get; set; }
        public double SellPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime SellDate { get; set; }
    }
}