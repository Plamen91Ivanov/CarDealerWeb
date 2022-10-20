using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public long TravelledDistance { get; set; }

        public List<Sale> Sales { get; set; } = new List<Sale>();

        public List<PartCar> Parts { get; set; } = new List<PartCar>();
    }
}
