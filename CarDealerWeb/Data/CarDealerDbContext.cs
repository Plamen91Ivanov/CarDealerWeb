using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerWeb.Data
{
    public class CarDealerDbContext : IdentityDbContext
    {
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
            : base(options)
        {
        }
    }
}
