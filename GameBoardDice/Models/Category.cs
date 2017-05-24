﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}