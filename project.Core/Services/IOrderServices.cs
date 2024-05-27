using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface IOrderServices
    {
       Task< List<Order>> GetAllAsync(string? text = "");
        Task<Order> GetAsync(int id);
        Task DeleteAsync(int id);
       Task< Order> PutAsync(int id, Order cust);
        Task<Order> PostAsync(Order cust);
    }
}

     