using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Restrotrackapi.Models;
using Restrotrackapi.Repos;

namespace Restrotrackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillRepo repo;

        public BillController(IBillRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBills()
        {
            try
            {
                var result = await repo.GetAllBills();
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetBillById([FromBody] string id)
        {
            try
            {
                var result = await repo.GetBillById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetBillByOrderId([FromBody] string orderId)
        {
            try
            {
                var result = await repo.GetBillByOrderId(orderId);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddBill([FromBody] Bill bill)
        {
            try
            {
                var result = await repo.AddNewBill(bill);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBill([FromBody] Bill bill)
        {
            try
            {
                var result = await repo.ModifyBill(bill);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBill([FromBody] string id)
        {
            try
            {
                var result = await repo.DeleteBillById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
