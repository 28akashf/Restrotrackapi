using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restrotrackapi.Models;
using Restrotrackapi.Repos;

namespace Restrotrackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepo repo;

        public PaymentController(IPaymentRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPayments()
        {
            try
            {
                var result = await repo.GetAllPayments();
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentById([FromBody] string id)
        {
            try
            {
                var result = await repo.GetPaymentById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentByOrderId([FromBody] string orderId)
        {
            try
            {
                var result = await repo.GetPaymentByOrderId(orderId);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddPayment([FromBody] Payment Payment)
        {
            try
            {
                var result = await repo.AddNewPayment(Payment);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePayment([FromBody] Payment Payment)
        {
            try
            {
                var result = await repo.ModifyPayment(Payment);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePayment([FromBody] string id)
        {
            try
            {
                var result = await repo.DeletePaymentById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
