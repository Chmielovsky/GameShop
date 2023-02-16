using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShopUI.Models
{
    [Table("Game")]
    public class Game
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(50)]
        public string? GameName { get; set; }

        public string? AuthorName { get; set; }
        public double Price { get; set; }   
        public string? Image { get; set; }  
        [System.ComponentModel.DataAnnotations.Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }   
        public List<CartDetail> CartDetails { get; set; }

        [NotMapped]
        public string GenreName { get; set; }
    }
}
