using GameBoardDice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameBoardDice.DAL
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("StoreContext")
        {
        }

        //public StoreContext()
        //{
        //    Database.SetInitializer<StoreContext>(new StoreInitializer());
        //}

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}