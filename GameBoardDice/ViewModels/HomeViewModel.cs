using GameBoardDice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> Bestsellers { get; set; }
        public IEnumerable<Game> NewGames { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}