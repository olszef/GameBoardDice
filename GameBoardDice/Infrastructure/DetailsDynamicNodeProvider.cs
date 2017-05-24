using GameBoardDice.DAL;
using GameBoardDice.Models;
using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.Infrastructure
{
    public class DetailsDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext db = new StoreContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            List<DynamicNode> nodes = new List<DynamicNode>();

            foreach (Game game in db.Games)
            {
                DynamicNode gameNode = new DynamicNode();
                gameNode.Title = game.GameName;
                gameNode.Key = "Game_" + game.GameID;
                gameNode.ParentKey = "Category_" + game.CategoryId;
                gameNode.RouteValues.Add("id", game.GameID);
                nodes.Add(gameNode);
            }

            return nodes;
        }     
    }
}