using CarDealer.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data
{
    public class CarDealerDbContext : IdentityDbContext
    {
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<PartCar>()
                .HasKey(pc => new { pc.PartId, pc.CarId });

            builder
                .Entity<PartCar>()
                .HasOne(c => c.Car)
                .WithMany(p => p.Parts)
                .HasForeignKey(c => c.CarId);

            builder
                .Entity<PartCar>()
                .HasOne(p => p.Part)
                .WithMany(c => c.Cars)
                .HasForeignKey(p => p.PartId);

            builder
                .Entity<Sale>()
                .HasOne(s => s.Car)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CarId);

            builder
                .Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustormerId);
            builder
                .Entity<Supplier>()
                .HasMany(s => s.Parts)
                .WithOne(c => c.Supplier)
                .HasForeignKey(c => c.SupplierId);

            base.OnModelCreating(builder);
        }
    }
}
