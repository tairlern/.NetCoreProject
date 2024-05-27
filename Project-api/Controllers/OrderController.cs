using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project_api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        private readonly IOrderServices _orders;
        private readonly IMapper _mapper;
        
        public OrderController(IOrderServices OrderService ,IMapper mapper)
        {
            _orders = OrderService;
            _mapper = mapper;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IEnumerable<Order>> GetAsync()
        {
            return await _orders.GetAllAsync();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task< Order> GetAsync(int id)
        {
            var order =await _orders.GetAsync(id);
            var orderDbo = _mapper.Map<OrderDto>(order);

            return order;
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] OrderPostModel ordr)
        {
        
            var order = new Order { Name = ordr.Name, DateOrder = ordr.DateOrder, CountProdact = ordr.CountProdact };
            var OrderResult = await _orders.PostAsync(order);


           return  Ok(OrderResult)  ;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public  async Task PutAsync(int id, [FromBody] Order ordr)
        {
          
            await _orders.PutAsync(id, ordr);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
          await _orders.DeleteAsync(id);
            return NoContent();
        }
    }
}
