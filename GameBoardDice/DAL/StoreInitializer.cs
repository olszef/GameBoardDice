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
                new Category() { CategoryId = 1, Name = "educational", IconFileName = "education.svg" },
                new Category() { CategoryId = 2, Name = "economy", IconFileName = "economy.svg" },
                new Category() { CategoryId = 3, Name = "party", IconFileName = "party.svg" },
                new Category() { CategoryId = 4, Name = "cards", IconFileName = "cards.svg" },
                new Category() { CategoryId = 5, Name = "logical", IconFileName = "logic.svg" },
                new Category() { CategoryId = 6, Name = "dice", IconFileName = "dice.svg" },
                new Category() { CategoryId = 7, Name = "adventure", IconFileName = "adventure.svg" },
                new Category() { CategoryId = 8, Name = "strategy", IconFileName = "strategy.svg" },
                new Category() { CategoryId = 9, Name = "sport", IconFileName = "sport.svg" },
                new Category() { CategoryId = 10, Name = "agility", IconFileName = "agility.svg" },
                new Category() { CategoryId = 11, Name = "war", IconFileName = "war.svg" },
                new Category() { CategoryId = 12, Name = "family", IconFileName = "family.svg" },
                new Category() { CategoryId = 13, Name = "other", IconFileName = "other.svg" },
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();

            var games = new List<Game>()
            {
                new Game() { GameID = 1, GameName = "Dixit", Publisher = "Rebel", Price = 99, BoxFileName = "dixit.jpg", IsBestSeller = true, DateAdded = new DateTime(2015, 01, 1), CategoryId = 12 },
                new Game() { GameID = 2, GameName = "Splendor", Publisher = "Rebel", Price = 22, BoxFileName = "splendor.jpg", IsBestSeller = false, DateAdded = new DateTime(2014, 02, 7), CategoryId = 2 },
                new Game() { GameID = 3, GameName = "Dobble", Publisher = "Rebel", Price = 66, BoxFileName = "dobble.jpg", IsBestSeller = true, DateAdded = new DateTime(2017, 04, 4), CategoryId = 3 },
                new Game() { GameID = 4, GameName = "Chaos", Publisher = "Galakta", Price = 13, BoxFileName = "chaos.jpg", IsBestSeller = true, DateAdded = new DateTime(2016, 06, 3), CategoryId =11 },
                new Game() { GameID = 5, GameName = "Patchwork", Publisher = "Lacerta", Price = 78, BoxFileName = "patchwork.jpg", IsBestSeller = false, DateAdded = new DateTime(2013, 06, 1), CategoryId = 13 },
                new Game() { GameID = 6, GameName = "Monopoly Deal", Publisher = "Hasbro", Price = 23, BoxFileName = "deal.jpg", IsBestSeller = false, DateAdded = new DateTime(2012, 01, 8), CategoryId = 4 },
                new Game() { GameID = 7, GameName = "Munchkin", Publisher = "Black Monk", Price = 123, BoxFileName = "munchkin.png", IsBestSeller = true, DateAdded = new DateTime(2011, 11, 11), CategoryId = 7 },
                new Game() { GameID = 8, GameName = "7 cudów świata", Publisher = "Rebel", Price = 15, BoxFileName = "7mir.jpg", IsBestSeller = true, DateAdded = new DateTime(2010, 05, 15), CategoryId = 8 },
                new Game() { GameID = 9, GameName = "Taboo", Publisher = "Hasbro", Price = 16, BoxFileName = "taboo.jpg", IsBestSeller = true, DateAdded = new DateTime(2015, 12, 17), CategoryId = 3 },
                new Game() { GameID = 10, GameName = "Alchemicy", Publisher = "Rebel", Price = 88, BoxFileName = "alchemicy.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 2 },
                new Game() { GameID = 11, GameName = "Cortex", Publisher = "Rebel", Price = 83, BoxFileName = "cortex.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 1 },
                new Game() { GameID = 12, GameName = "Rój", Publisher = "G3", Price = 81, BoxFileName = "hive.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 5 },
                new Game() { GameID = 13, GameName = "Kowale losu", Publisher = "Rebel", Price = 89, BoxFileName = "blacksmiths.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 6 },
                new Game() { GameID = 14, GameName = "Smoczy wyścig", Publisher = "Ogry Games", Price = 88, BoxFileName = "dragonsrace.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 9 },
                new Game() { GameID = 15, GameName = "Prawo dżungli", Publisher = "Rebel", Price = 88, BoxFileName = "junglespeed.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 10 },
                new Game() { GameID = 16, GameName = "Osadnicy z Catanu", Publisher = "Galakta", Price = 88, BoxFileName = "catan.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 2 },
                new Game() { GameID = 17, GameName = "Abyss", Publisher = "Rebel", Price = 78, BoxFileName = "abyss.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 2 },
                new Game() { GameID = 18, GameName = "Agricola", Publisher = "Lacerta", Price = 91, BoxFileName = "agricola.jpg", IsBestSeller = false, DateAdded = new DateTime(2015, 11, 14), CategoryId = 2 },
            };

            games.ForEach(g => context.Games.AddOrUpdate(g));
            context.SaveChanges();
        }
    }
}