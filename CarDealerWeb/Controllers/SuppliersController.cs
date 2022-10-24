using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarDealer.Data;
using CarDealer.Services;
using CarDealerWeb.Models.Suppliers;

namespace CarDealerWeb.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService suppliers;

        private const string SuppliersView = "Suppliers";

        public SuppliersController(ISupplierService suppliers)
        {
            this.suppliers = suppliers;
        }

        public IActionResult Local()
        {
            return View(SuppliersView, this.GetSupplierModel(false));
        }

        public IActionResult Importers()
        {
            return View(SuppliersView, this.GetSupplierModel(true));
        }

        public SuppliersModel GetSupplierModel(bool importers)
        {
            var type = importers ? "Importer" : "Local";
            var suppliers = this.suppliers.All(importers);

            return new SuppliersModel
            {
                Type = type,
                Suppliers = suppliers
            };
        }
    }

}
