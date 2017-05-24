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
            var categoryGames = db.Categories.Include("Game").Where(c => c.Name.ToLower() == category.ToLower());

            return View(categoryGames);
        }
    }
}