using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Services.Models;

namespace CarDealerWeb.Models.Suppliers
{
    public class SuppliersModel
    {
        public string Type { get; set; }

        public IEnumerable<SupplierModel> Suppliers { get; set; }
    }
}
