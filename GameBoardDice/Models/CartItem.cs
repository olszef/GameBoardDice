using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.Models
{
    public class CartItem
    {
        public Game Game { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}