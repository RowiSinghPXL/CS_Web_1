using Microsoft.AspNetCore.Mvc;
using MVCFifa21.Data;
using MVCFifa21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFifa21.Controllers
{
    public class TeamController : Controller
    {
        //dependency injection
        ApplicationDbContext _context;
        public TeamController(ApplicationDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public IActionResult Index()
        {
            var teams = _context.Teams;
            return View(teams);
        }

       [HttpGet]
       public IActionResult Create()
        {
            var team = new Team();
            return View(team);
        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            if (ModelState.IsValid)
            {
                _context.Teams.Add(team);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team);
        }
       
    }
}
