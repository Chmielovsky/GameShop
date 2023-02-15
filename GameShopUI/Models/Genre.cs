using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameShopUI.Models
{
    [Table("Genre")]
    public class Genre
    {
 
            public int Id { get; set; }

            [System.ComponentModel.DataAnnotations.Required]
            [MaxLength(50)]
            public string GenreName { get; set; }
        public List<Game> Games;

        
    }
}
