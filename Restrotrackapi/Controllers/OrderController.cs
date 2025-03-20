using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restrotrackapi.Models;
using Restrotrackapi.Repos;

namespace Restrotrackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo repo;

        public OrderController(IOrderRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                var result = await repo.GetAllOrders();
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderById([FromBody] string id)
        {
            try
            {
                var result = await repo.GetOrderById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderByOrderId([FromBody] string orderId)
        {
            try
            {
                var result = await repo.GetOrderByOrderId(orderId);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] Order Order)
        {
            try
            {
                var result = await repo.AddNewOrder(Order);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] Order Order)
        {
            try
            {
                var result = await repo.ModifyOrder(Order);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder([FromBody] string id)
        {
            try
            {
                var result = await repo.DeleteOrderById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
