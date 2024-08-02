using System.ComponentModel.DataAnnotations;

namespace LunaDreams_API.Models.DTO
{
    public class OrderDetailsCreate
    {
        [Required]
        public int MenuItemId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
