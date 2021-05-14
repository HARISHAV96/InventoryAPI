using InventoryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace InventoryAPI.IRepository
{
    public interface InventoryIRepository
    {
        Task Add(Inventory inventory);
        Task Update(Inventory inventory);
        Task Delete(string id);
        Task<Inventory> GetInventory(string id);
        Task<IEnumerable<Inventory>> GetInventories();
    }
}