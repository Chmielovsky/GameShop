﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShopUI.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public int OrderId { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]

        public int Quantity { get; set; }   
        public double UnitPrice { get; set; }   

        public Order Order { get; set; }    
        public Game game { get; set; } 
        
   }
}
