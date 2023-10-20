using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.Inventories.Interfaces;
using InventoryManagementSystem.UseCases.PluginInterfaces;

namespace InventoryManagementSystem.UseCases.Inventories
{
    public class EditInventoryUseCase : IEditInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EditInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            await inventoryRepository.EditInventoryAsync(inventory);
        }
    }
}
