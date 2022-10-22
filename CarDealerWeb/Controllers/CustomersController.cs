using CarDealer.Services;
using CarDealer.Services.Models;
using CarDealerWeb.Models.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerWeb.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService customer;

        public CustomersController(ICustomerService customer)
        {
            this.customer = customer;
        }

        [Route("customers/all/{order}")]
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "ascending"
                ? OrderDirection.Ascending
                : OrderDirection.Descending;

            var customers = this.customer.OrderedCustomers(orderDirection);

            return View(new AllCustomersModel
            {
                Customers = customers,
                OrderDirection = orderDirection
            });

        }
    }
}
