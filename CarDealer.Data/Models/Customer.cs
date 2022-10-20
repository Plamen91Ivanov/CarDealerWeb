﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name  { get; set; }

        public DateTime BirthDay { get; set; }

        public bool IsYoungDriver { get; set; }

        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}
