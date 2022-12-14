using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarDealer.Services;
using CarDealerWeb.Models.Cars;

namespace CarsDealerWeb.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService cars;

        public CarsController(ICarService cars)
        {
            this.cars = cars;
        }

        [Route("cars/{make}", Order = 2)]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return View(new CarsByMakeModel
            {
                Make = make,
                Cars = cars
            });
        }

        [Route("cars/parts", Order = 1)]
        public IActionResult Parts()
            => View(this.cars.WithParts());
    }
}
