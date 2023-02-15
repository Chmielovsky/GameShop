using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShopUI.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string UserId { get; set; } 
        public DateTime CreateDate { get; set; }= DateTime.UtcNow;
        [System.ComponentModel.DataAnnotations.Required]

        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }
        public List<OrderDetail>OrderDetail { get; set; }   

    }
}
