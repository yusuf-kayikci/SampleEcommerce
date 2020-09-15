using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleEcommerce.Business.Services;
using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Core.Api;
using SampleEcommerce.Data.Entity;

namespace SampleEcommerce.BasketApi.Controllers
{
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(IProductService service) : base(service)
        {
        }
    }
}
