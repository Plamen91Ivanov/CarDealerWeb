using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services.Models.Cars
{
    public class CarWithPartModel : CarModel
    {
        public IEnumerable<PartModel> Parts { get; set; }

        public IEnumerable<SalesModel> Sales { get; set; }

    }
}
