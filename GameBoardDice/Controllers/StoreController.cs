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

        public ActionResult List(string category)
        {
            var categoryData = db.Categories.Include("Games").Where(c => c.Name.ToLower() == category.ToLower()).Single();
            var games = categoryData.Games.ToList();

            return View(games);
        }
    }
}