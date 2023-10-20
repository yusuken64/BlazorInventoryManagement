using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.PluginInterfaces;
using System.Security.Cryptography.X509Certificates;

namespace InventoryManagementSystem.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory() { Id = 1, InventoryName = "Bike Seat",   Quantity = 10, Price = 2 },
                new Inventory() { Id = 2, InventoryName = "Bike Body",   Quantity = 10, Price = 15 },
                new Inventory() { Id = 3, InventoryName = "Bike Wheel",  Quantity = 20, Price = 8 },
                new Inventory() { Id = 4, InventoryName = "Bike Pedals", Quantity = 20, Price = 1 },
            };
        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.CurrentCultureIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var maxId = _inventories.Max(x => x.Id);
            inventory.Id = maxId + 1;

            _inventories.Add(inventory);

            return Task.CompletedTask;
        }

        public Task EditInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x => x.Id != inventory.Id &&
                x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var oldInventory = _inventories.FirstOrDefault(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.CurrentCultureIgnoreCase));
            if (oldInventory != null)
            {
                oldInventory.InventoryName = inventory.InventoryName;
                oldInventory.Price = inventory.Price;
                oldInventory.Quantity = inventory.Quantity;
            }

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id)
        {
            return await Task.FromResult(_inventories.FirstOrDefault(x => x.Id == id));
        }
    }
}