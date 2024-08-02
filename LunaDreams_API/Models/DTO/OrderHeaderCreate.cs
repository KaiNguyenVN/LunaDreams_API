using System.ComponentModel.DataAnnotations;

namespace LunaDreams_API.Models.DTO
{
    public class OrderHeaderCreate
    {
        [Required]
        public string PickupName { get; set; }
        [Required]
        public string PickupPhoneNumber { get; set; }
        [Required]
        public string PickupEmail { get; set; }

        public string ApplicationUserId { get; set; }
        public double OrderTotal { get; set; }


        public string StripePaymentIntentID { get; set; }
        public string Status { get; set; }
        public int TotalItems { get; set; }

        public IEnumerable<OrderDetailsCreate> OrderDetails { get; set; }
    }
}
