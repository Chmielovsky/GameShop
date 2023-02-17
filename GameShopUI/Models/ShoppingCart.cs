using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace GameShopUI.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CartDetail> CartDetails { get; set; }    
    }
}
