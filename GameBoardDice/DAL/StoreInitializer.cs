using GameBoardDice.Migrations;
using GameBoardDice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace GameBoardDice.DAL
{
    public class StoreInitializer : MigrateDatabaseToLatestVersion<StoreContext, Configuration>
    {
        //protected override void Seed(StoreContext context)
        //{
        //    SeedStoreData(context);
        //    base.Seed(context);
        //}

        public static void SeedStoreData(StoreContext context)
        {
            var categories = new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Edukacyjne", IconFileName = "education.svg" },
                new Category() { CategoryId = 2, Name = "Ekonomiczne", IconFileName = "economy.svg" },
                new Category() { CategoryId = 3, Name = "Imprezowe", IconFileName = "party.svg" },
                new Category() { CategoryId = 4, Name = "Karciane", IconFileName = "cards.svg" },
                new Category() { CategoryId = 5, Name = "Logiczne", IconFileName = "logic.svg" },
                new Category() { CategoryId = 6, Name = "Kościane", IconFileName = "dice.svg" },
                new Category() { CategoryId = 7, Name = "Przygodowe", IconFileName = "adventure.svg" },
                new Category() { CategoryId = 8, Name = "Strategiczne", IconFileName = "strategy.svg" },
                new Category() { CategoryId = 9, Name = "Sportowe", IconFileName = "sport.svg" },
                new Category() { CategoryId = 10, Name = "Zręcznościowe", IconFileName = "agility.svg" },
                new Category() { CategoryId = 11, Name = "Wojenne", IconFileName = "war.svg" },
                new Category() { CategoryId = 12, Name = "Familijne", IconFileName = "family.svg" },
                new Category() { CategoryId = 13, Name = "Inne", IconFileName = "other.svg" },
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();

            var games = new List<Game>()
            {
                new Game() { GameID = 1, GameName = "Dixit", Publisher = "Rebel", Price = 99, BoxFileName = "1.png", IsBestSeller = true, DateAdded = new DateTime(2015, 01, 1), CategoryId = 1 },
                new Game() { GameID = 2, GameName = "Splendor", Publisher = "Rebel", Price = 22, BoxFileName = "2.png", IsBestSeller = false, DateAdded = new DateTime(2014, 02, 7), CategoryId = 2 },
                new Game() { GameID = 3, GameName = "Dobble", Publisher = "Zuo", Price = 66, BoxFileName = "3.png", IsBestSeller = true, DateAdded = new DateTime(2017, 04, 4), CategoryId = 1 },
                new Game() { GameID = 4, GameName = "Wojna", Publisher = "Miszcze", Price = 13, BoxFileName = "4.jpg", IsBestSeller = true, DateAdded = new DateTime(2016, 06, 3), CategoryId = 2 },
                new Game() { GameID = 5, GameName = "Patchwork", Publisher = "hyhy", Price = 78, BoxFileName = "5.png", IsBestSeller = false, DateAdded = new DateTime(2013, 06, 1), CategoryId = 2 },
                new Game() { GameID = 6, GameName = "Poker", Publisher = "werere", Price = 23, BoxFileName = "6.png", IsBestSeller = false, DateAdded = new DateTime(2012, 01, 8), CategoryId = 3 },
                new Game() { GameID = 7, GameName = "Munchkin", Publisher = "Rebel", Price = 123, BoxFileName = "7.png", IsBestSeller = true, DateAdded = new DateTime(2011, 11, 11), CategoryId = 3 },
                new Game() { GameID = 8, GameName = "7 cudów świata", Publisher = "jshgdfhgs", Price = 15, BoxFileName = "8.png", IsBestSeller = true, DateAdded = new DateTime(2010, 05, 15), CategoryId = 1 },
                new Game() { GameID = 9, GameName = "Taboo", Publisher = "Rebel", Price = 16, BoxFileName = "9.png", IsBestSeller = true, DateAdded = new DateTime(2015, 12, 17), CategoryId = 1 },
                new Game() { GameID = 10, GameName = "Alchemicy", Publisher = "Rebel", Price = 88, BoxFileName = "10.png", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 2 },
            };

            games.ForEach(g => context.Games.AddOrUpdate(g));
            context.SaveChanges();
        }
    }
}