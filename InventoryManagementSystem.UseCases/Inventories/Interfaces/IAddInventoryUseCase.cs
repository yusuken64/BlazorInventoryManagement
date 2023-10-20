using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.Inventories.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}