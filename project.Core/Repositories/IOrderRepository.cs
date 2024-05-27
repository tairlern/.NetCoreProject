using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetListAsync();
       Task< Order> GetAsync(int id);
        Task DeleteAsync(int id);
        Task<Order> PutAsync(int id, Order cust);
        Task<Order> PostAsync(Order cust);
    }
}
