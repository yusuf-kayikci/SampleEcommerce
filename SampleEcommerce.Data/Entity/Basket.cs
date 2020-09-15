using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Entity
{
    public class Basket : BaseEntity
    {
        public string ProductId { get; set; }
        public int Amount { get; set; }
    }
}
