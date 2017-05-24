using GameBoardDice.DAL;
using GameBoardDice.Models;
using GameBoardDice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameBoardDice.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: Home
        public ActionResult Index()
        {
            var categories = db.Categories.ToList();
            var newGames = db.Games.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(6).ToList();
            var bestsellers = db.Games.Where(a => !a.IsHidden && a.IsBestSeller).OrderBy(g => Guid.NewGuid()).Take(6).ToList();

            var vm = new HomeViewModel()
            {
                Categories = categories,
                NewGames = newGames,
                Bestsellers = bestsellers
            };

            return View(vm);
        }

        public ActionResult StaticContent(string viewname)
        {
            ViewBag.Title = "";
            return View(viewname);
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult ShippingDetails()
        {
            return View();
        }
    }
}