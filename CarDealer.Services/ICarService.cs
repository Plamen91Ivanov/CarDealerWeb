using System;
using System.Collections.Generic;
using System.Text;
using CarDealer.Services.Models.Cars;

namespace CarDealer.Services
{
    public interface ICarService
    {
         IEnumerable<CarModel> ByMake(string make);

        IEnumerable<CarWithPartModel> WithParts();

    }   
}
