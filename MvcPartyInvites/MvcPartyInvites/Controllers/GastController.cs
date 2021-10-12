using Microsoft.AspNetCore.Mvc;
using MvcPartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPartyInvites.Controllers
{
    public class GastController : Controller
    {
        public IActionResult Index()
        {
            Gast g = new Gast();
            return View();
        }
        [HttpPost]
        public IActionResult Reservatie(Gast g)
        {

            if (ModelState.IsValid)
            {
                MvcPartyInvites.Data.LocalData.GastList.Add(g);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index", g);
            }
        }


    }
}
