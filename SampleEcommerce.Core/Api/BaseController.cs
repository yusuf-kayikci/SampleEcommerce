using Microsoft.AspNetCore.Mvc;
using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Core.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : BaseEntity
    {

        private readonly IService<T> _service;
        public BaseController(IService<T> service)
        {
            _service = service;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        virtual public IEnumerable<T> Get()
        {
            return _service.GetAll();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        virtual public T Get(string id)
        {
            return _service.GetById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        virtual public void Post([FromBody] T value)
        {
            _service.Add(value);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        virtual public void Put(string id, [FromBody] T value)
        {
            _service.Update(id, value);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        virtual public void Delete(string id)
        {
            _service.Delete(id);
        }
    }
}
