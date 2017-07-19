using GameBoardDice.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameBoardDice.Controllers
{
    public class StoreController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: Store
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult List(string category, string searchQuery = null)
        {
            var categoryData = db.Categories.Include("Games").Where(c => c.Name.ToUpper() == category.ToUpper()).Single();
            var games = categoryData.Games.Where(g => (searchQuery == null || g.GameName.ToLower().Contains(searchQuery.ToLower()) ||
                                                                              g.Publisher.ToLower().Contains(searchQuery.ToLower())) && !g.IsHidden);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_List", games);
            }

            return View(games);
        }

        public ActionResult GamesSuggestions(string term)
        {
            var games = this.db.Games.Where(g => !g.IsHidden && g.GameName.ToLower().Contains(term.ToLower())).Take(5).Select(g => new { label = g.GameName });
            return Json(games, JsonRequestBehavior.AllowGet);
        }
    }
}