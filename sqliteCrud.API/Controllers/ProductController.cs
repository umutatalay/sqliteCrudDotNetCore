using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sqliteCrud.Business.Abstract;
using sqliteCrud.Business.Concreate;
using sqliteCrud.Entities;

namespace sqliteCrud.API.Controllers
{

    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private IProductService productService;
        public ProductController()
        {
            productService = new ProductManager();
        }



        [HttpGet]
        [Route("Hepsi")]
        public List<Product> Get()
        {
            return productService.GetAll();
        }


        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productService.GetById(id);
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return productService.Create(product);
        }

        [HttpPut]
        public Product Put([FromBody] Product product)
        {
            return productService.Update(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productService.Delete(id);
        }
    }
}
