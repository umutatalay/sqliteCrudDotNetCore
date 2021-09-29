using Microsoft.EntityFrameworkCore;
using sqliteCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace sqliteCrud.DataAccess
{
    public class sqliteDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\SQLiteDB\testdbsqlite.db");
    }
}
