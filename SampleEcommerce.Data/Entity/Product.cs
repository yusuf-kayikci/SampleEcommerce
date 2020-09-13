using SampleEcommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
