using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task EditInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
        Task<Inventory> GetInventoryByIdAsync(int id);
    }
}