using InventoryAPI.IRepository;
using InventoryAPI.Models;
using InventoryAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InventoryAPI.Controllers
{
    public class InventoryApiController : ApiController
    {
        private readonly InventoryIRepository _IinventoryIRepository = new InventoryRepository();

        [HttpGet]
        [Route("api/Inventories/Get")]
        public async Task<IEnumerable<Inventory>> Get()
        {
            return await _IinventoryIRepository.GetInventories();
        }

        [HttpPost]
        [Route("api/Inventories/Create")]
        public async Task CreateAsync([FromBody] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                await _IinventoryIRepository.Add(inventory);
            }
        }


        [HttpGet]
        [Route("api/Inventories/Details/{id}")]
        public async Task<Inventory> Details(string id)
        {
            var result = await _IinventoryIRepository.GetInventory(id);
            return result;
        }

        [HttpPut]
        [Route("api/Inventories/Edit")]
        public async Task EditAsync([FromBody] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                await _IinventoryIRepository.Update(inventory);
            }
        }

        [HttpDelete]
        [Route("api/Inventories/Delete/{id}")]
        public async Task DeleteConfirmedAsync(string id)
        {
            await _IinventoryIRepository.Delete(id);
        }
    }
}
