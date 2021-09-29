using sqliteCrud.Business.Abstract;
using sqliteCrud.DataAccess.Abstract;
using sqliteCrud.DataAccess.Concrete;
using sqliteCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqliteCrud.Business.Concreate
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }

        public Product Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public void Delete(int id)
        {
             _productRepository.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product Update(Product product)
        {
            // -->
            return _productRepository.Update(product);
            
        }
    }
}
