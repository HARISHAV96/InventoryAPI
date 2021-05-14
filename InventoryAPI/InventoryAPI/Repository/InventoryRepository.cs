using InventoryAPI.IRepository;
using InventoryAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace InventoryAPI.Repository
{
    public class InventoryRepository : InventoryIRepository
    {
        private readonly CRUDDBEntities db = new CRUDDBEntities();
        public async Task Add(Inventory inventory)
        {
            inventory.ItemId = Guid.NewGuid().ToString();
            db.Inventories.Add(inventory);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<Inventory> GetInventory(string id)
        {
            try
            {
                Inventory inventory = await db.Inventories.FindAsync(id);
                if (inventory == null)
                {
                    return null;
                }
                return inventory;
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Inventory>> GetInventories()
        {
            try
            {
                var inventories = await db.Inventories.ToListAsync();
                return inventories.AsQueryable();
            }
            catch
            {
                throw;
            }
        }
        public async Task Update(Inventory inventory)
        {
            try
            {
                db.Entry(inventory).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                Inventory inventory = await db.Inventories.FindAsync(id);
                db.Inventories.Remove(inventory);
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        private bool InventoryExists(string id)
        {
            return db.Inventories.Count(e => e.ItemId == id) > 0;
        }

    
}
}