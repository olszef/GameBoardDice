using GameBoardDice.DAL;
using GameBoardDice.Models;
using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBoardDice.Infrastructure
{
    public class CategoriesDynamicNodeProvider : DynamicNodeProviderBase
    {
        StoreContext db = new StoreContext(); 

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            List<DynamicNode> nodes = new List<DynamicNode>();

            foreach (Category category in db.Categories)
            {
                DynamicNode categoryNode = new DynamicNode();
                categoryNode.Title = category.Name;
                categoryNode.Key = "Category_" + category.CategoryId;
                categoryNode.RouteValues.Add("category", category.Name);
                nodes.Add(categoryNode);
            }

            return nodes;
        }
    }
}