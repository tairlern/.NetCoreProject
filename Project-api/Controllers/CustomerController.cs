using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Core.Models;
using Project.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerServices _customers;

        public CustomerController(ICustomerServices custService)
        {
            _customers = custService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> GetAsync(string? text = "")
        {
            return Ok(await _customers.GetAllAsync(text));
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<Customer> GetAsync(int id)
        {
            return await _customers.GetAsync(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task PostAsync([FromBody] Customer cust)
        {
          await  _customers.PostAsync(cust);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(int id, [FromBody] Customer cust)
        {
         await   _customers.PutAsync(id,cust);

        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
          await  _customers.DeleteAsync( id);
            return NoContent();
        }
    }
}
