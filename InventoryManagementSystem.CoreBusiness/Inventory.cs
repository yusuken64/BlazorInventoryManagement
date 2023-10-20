using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.CoreBusiness
{
	public class Inventory
	{
		public int Id { get; set; }

		[Required]
		public string InventoryName { get; set; } = string.Empty;

		[Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
		public int Quantity { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
		public decimal Price { get; set; }
	}
}