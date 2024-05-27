
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Customer> CustomerList { get; set; }

        public DbSet<Order> OrderList { get; set; }
        public DbSet<Product> ProductList { get; set; }
        public DbSet<ProdactToOrder> ProdactToOrderList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DbProjectT1_db");
           
        }
    }
}
