using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleEcommerce.Business.Services;
using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Core.Api;
using SampleEcommerce.Data.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleEcommerce.ProductApi.Controllers
{
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(IService<Product> service) : base(service)
        {
        }
    }
}
