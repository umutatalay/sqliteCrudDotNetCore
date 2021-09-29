using sqliteCrud.DataAccess.Abstract;
using sqliteCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sqliteCrud.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product Create(Product product)
        {
            using (var sqliteDbContext = new sqliteDbContext())
            {
                sqliteDbContext.Products.Add(product);
                sqliteDbContext.SaveChanges();
                return product;

            }
        }

        public void Delete(int id)
        {
            using (var sqliteDbContext = new sqliteDbContext())
            {
                var Deleted = GetById(id);
                sqliteDbContext.Products.Remove(Deleted);
                sqliteDbContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (var sqliteDbContext = new sqliteDbContext())
            {
                return sqliteDbContext.Products.ToList();

            }
        }

        public Product GetById(int id)
        {
            using (var sqliteDbContext = new sqliteDbContext())
            {
                return sqliteDbContext.Products.Find(id);
            }
        }

        public Product Update(Product product)
        {

            using (var sqliteDbContext = new sqliteDbContext())
            {
                sqliteDbContext.Products.Update(product);
                sqliteDbContext.SaveChanges();
                return product;
            }
        }
    }
}
