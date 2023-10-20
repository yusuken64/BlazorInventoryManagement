using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}