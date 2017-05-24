using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }
        public string Publisher { get; set; }
        public DateTime DateAdded { get; set; }
        public string BoxFileName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsHidden { get; set; }

        public virtual Category Category { get; set; }
    }
}