using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.Inventories.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}