using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class CustomerReposetory: ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerReposetory (DataContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetListAsync()
        {
            return await  _context.CustomerList.ToListAsync();
        }
         public async Task<Customer> GetAsync(int id)
        {
            return await _context.CustomerList.FindAsync(id);
        }
        public async Task DeleteAsync(int id)
        {
            var c=await GetAsync(id);
            _context.CustomerList.Remove(c);
          await  _context.SaveChangesAsync();
        }

        public async Task<Customer> PutAsync(int id, Customer cust)
        {
            var c =await GetAsync(id);
           c.Id = cust.Id;
            c .Name = cust.Name;
         await   _context.SaveChangesAsync();
            return c;
        }
        public async Task< Customer> PostAsync(Customer cust)
        {

            _context.CustomerList.Add(cust);
          await  _context.SaveChangesAsync();
            return cust;
        }
        public async Task<Customer> GetByCustomerNameAndPassword(string customerName, string password)
        {
            return _context.CustomerList.FirstOrDefault(u => u.Name == customerName && u.Password==password);
        }
    }
}
