using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository userRepository)
        {
            _CustomerRepository = userRepository;
        }

        public async Task<List<Customer>> GetAllAsync(string? text = "")
        {
            //לוגיקה עסקית
            return await _CustomerRepository.GetListAsync();
        }
        public async Task<Customer> GetAsync(int id)
        {
            return await _CustomerRepository.GetAsync(id);
        }
        public async Task DeleteAsync(int id)
        {
         await   _CustomerRepository.DeleteAsync(id);
           
        }

        public async Task<Customer> PutAsync(int id, Customer cust)
        {
           return await _CustomerRepository.PutAsync(id, cust);
            
        }
        public async Task<Customer> PostAsync(Customer cust)
        {
           return await _CustomerRepository.PostAsync(cust);
           
        }
        public Task<Customer> GetByCustomerNameAndPassword(string userName, string password)
        {
            return _CustomerRepository.GetByCustomerNameAndPassword(userName, password);
        }
    }
}
