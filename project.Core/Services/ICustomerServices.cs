using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface ICustomerServices
    {
        Task<List<Customer>> GetAllAsync(string? text = "");
       Task< Customer> GetAsync(int id);
        Task DeleteAsync(int id);
      Task<  Customer> PutAsync(int id,  Customer cust);
       Task< Customer> PostAsync(Customer cust);
        Task<Customer> GetByCustomerNameAndPassword(string customerName, string password);
    }
   
}
