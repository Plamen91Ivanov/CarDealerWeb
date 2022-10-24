using CarDealer.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarDealer.Data;
using CarDealer.Services.Models;

namespace CarDealer.Services
{
    public class CarService : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CarModel> ByMake(string make)
            => this.db
                .Cars
                .Where(c => c.Make.ToLower() == make.ToLower())
                .OrderBy(c => c.Model)
                .ThenBy(c => c.TravelledDistance)
                .Select(c => new CarModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToList();

        public IEnumerable<CarWithPartModel> WithParts()
            => this.db
            .Cars
            .Select(c => new CarWithPartModel
            {
                Make = c.Make,
                Model = c.Model,
                TravelledDistance = c.TravelledDistance,
                Parts = c.Parts.Select(p => new PartModel
                {
                    Name = p.Part.Name,
                    Price = p.Part.Price,
                }),
                Sales = c.Sales.Select(s => new SalesModel
                {
                    Discount = s.Discount
                })
            })
            .ToList();
    }
}
