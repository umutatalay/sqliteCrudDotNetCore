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
    }
}
