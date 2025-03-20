using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restrotrackapi.Models;
using Restrotrackapi.Repos;

namespace Restrotrackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepo repo;

        public StaffController(IStaffRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStaffs()
        {
            try
            {
                var result = await repo.GetAllStaffs();
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetStaffById([FromBody] string id)
        {
            try
            {
                var result = await repo.GetStaffById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> GetStaffByOrderId([FromBody] string orderId)
        //{
        //    try
        //    {
        //        var result = await repo.GetStaffByOrderId(orderId);
        //        return Ok(result);
        //    }
        //    catch (Exception)
        //    {
        //        return new StatusCodeResult(500);
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> AddStaff([FromBody] Staff Staff)
        {
            try
            {
                var result = await repo.AddNewStaff(Staff);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStaff([FromBody] Staff Staff)
        {
            try
            {
                var result = await repo.ModifyStaff(Staff);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStaff([FromBody] string id)
        {
            try
            {
                var result = await repo.DeleteStaffById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
