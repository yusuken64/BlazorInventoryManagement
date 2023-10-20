using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.PluginInterfaces;

namespace InventoryManagementSystem.UseCases.Inventories.Interfaces
{
    public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> ExecuteAsync(int Id)
        {
            var inventory = await inventoryRepository.GetInventoryByIdAsync(Id);
            var newInventory = new Inventory()
            {
                Id = inventory.Id,
                InventoryName = inventory.InventoryName,
                Price = inventory.Price,
                Quantity = inventory.Quantity
            };

            return newInventory;
        }
    }
}
