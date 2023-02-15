using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace GameShopUI.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]  
        public int GameId { get; set; }
        [Required]  
        public int Quantity { get; set; }
         public Game Game { get; set; } 
        public ShoppingCart ShoppingCart { get; set; }  

    }
}
