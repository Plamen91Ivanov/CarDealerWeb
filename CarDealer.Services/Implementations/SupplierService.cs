using System;
using System.Collections.Generic;
using System.Text;
using CarDealer.Data;
using System.Linq;
using CarDealer.Services.Models;

namespace CarDealer.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SupplierModel> All(bool IsImporter)
            => this.db
                .Suppliers
                .Where(s => s.IsImporter == IsImporter)
                .Select(s => new SupplierModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    TottalParts = s.Parts.Count
                })
                .ToList();  
    }
}
