using GameBoardDice.DAL;
using GameBoardDice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.Infrastructure
{
    public class ShoppingCartManager
    {
        private StoreContext db;
        private ISessionManager session;
        public const string CartSessionKey = "CartData";

        public ShoppingCartManager(ISessionManager session, StoreContext db)
        {
            this.session = session;
            this.db = db;
        }

        //public void AddToCart(int gameId)
        //{
        //    var cart = this.GetCart();

        //    var cartItem = cart.Find(c => c.Game.GameId == gameId);

        //    if (cartItem !=null)
        //    {
        //        cartItem.Quantity++;
        //    }
        //    else
        //    {
        //        var gameToAdd = db.Games.Where(g => g.GameID == gameId).SingleOrDefault();
        //        if (gameToAdd != null)
        //        {
        //            var newCartItem = new CartItem()
        //            {
        //                Game = gameToAdd,
        //                Quantity = 1,
        //                TotalPrice = gameToAdd.Price
        //            };

        //            cart.Add(newCartItem);
        //        }
        //    }

        //    session.Set(CartSessionKey, cart);
        //}
    }
}