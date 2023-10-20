using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.Inventories
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int Id);
    }
}