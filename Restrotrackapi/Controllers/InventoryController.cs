using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restrotrackapi.Models;
using Restrotrackapi.Repos;

namespace Restrotrackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepo repo;

        public InventoryController(IInventoryRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInventorys()
        {
            try
            {
                var result = await repo.GetAllInventoryItems();
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetInventoryById([FromBody] string id)
        {
            try
            {
                var result = await repo.GetInventoryItemById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddInventory([FromBody] InventoryItem item)
        {
            try
            {
                var result = await repo.AddNewInventoryItem(item);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateInventory([FromBody] InventoryItem item)
        {
            try
            {
                var result = await repo.ModifyInventoryItem(item);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteInventory([FromBody] string id)
        {
            try
            {
                var result = await repo.DeleteInventoryItemById(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
