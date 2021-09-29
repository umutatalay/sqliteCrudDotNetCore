using sqliteCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqliteCrud.DataAccess.Abstract
{
    public interface IProductRepository
    {

        List<Product> GetAll();

        Product GetById(int id);

        Product Create(Product product);

        Product Update(Product product);

        void Delete(int id);
    }
}
