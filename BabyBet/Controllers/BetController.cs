using BabyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabyBet.Controllers
{
    public class BetController : Controller
    {
        //
        // GET: /Bet/

        public ActionResult Index()
        {
            var e = new BabyBet1Entities();


            return View(e.Bets);
        }

        public ActionResult Create()
        {
            return View(new Bet());
        }

        [HttpPost]
        public ActionResult Create(Bet newBet)
        {
            if (base.ModelState.IsValid)
            {
                var e = new BabyBet1Entities();
                e.Bets.Add(newBet);
                e.SaveChanges();
                Redirect("Index");
            }
            return View(newBet); 
        }

    }
}
