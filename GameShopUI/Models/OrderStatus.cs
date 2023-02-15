using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShopUI.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public int StatusId { get; set; }   
        [Required,MaxLength(25)]
        public string StatusName { get; set; }
    }
}
