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
    public class OrderService : IOrderServices
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository userRepository)
        {
            _OrderRepository = userRepository;
        }

        public async Task<List<Order>> GetAllAsync(string? text = "")
        {
            
            return await _OrderRepository.GetListAsync();

        }
        public async Task<Order> GetAsync(int id)
        {
            return await _OrderRepository.GetAsync(id);
        }
        public async Task DeleteAsync(int id)
        {
            await    _OrderRepository.DeleteAsync(id);
        }
        public async Task< Order> PutAsync(int id, Order ordr) {
           return await _OrderRepository.PutAsync(id, ordr);
        }
        public async Task<Order> PostAsync(Order ordr)
        {
            return await _OrderRepository.PostAsync(ordr);
        }
    }
}
