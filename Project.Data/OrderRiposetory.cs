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
    public class OrderRiposetory : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRiposetory(DataContext context)
        {
            _context = context;
        }
         
        public async Task< List<Order>> GetListAsync()
        {
            
            return await _context.OrderList.Include(u=>u.Products).ToListAsync(); 
        }
        public async Task<Order> GetAsync(int id)
        {
            return await _context.OrderList.FindAsync( id);
        }
        public async Task DeleteAsync(int id)
        {
           
            var o=await GetAsync(id);
            _context.OrderList.Remove(o);
            await _context.SaveChangesAsync();  
        }
        public async Task<Order> PutAsync(int id, Order ordr)
        {

            var o=await GetAsync(id);
            o.Id = ordr.Id;
           //o.Product= ordr.Product;
            o.CountProdact = ordr.CountProdact;
           o.DateOrder = ordr.DateOrder;
          await  _context.SaveChangesAsync();
        //    await Task.WhenAll(o, _context);
            return o;
        }
        public async Task<Order> PostAsync(Order ordr)
        {
              _context.OrderList.Add(ordr);
            await _context.SaveChangesAsync();
           return ordr;
        }
    }
}
