using sqliteCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqliteCrud.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        Product Create(Product product);

        Product Update(Product product);

        void Delete(int id);
    }
}
