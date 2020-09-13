using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Core.Entity
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public long CreatedDate { get; set; }
        public long DeletedDate { get; set; }
    }
}
