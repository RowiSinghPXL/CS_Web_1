using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MVCFifa21.Data;
using MVCFifa21.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFifa21.Controllers
{
    public class PlayerController : Controller
    {
        IWebHostEnvironment _enviromont;
        ApplicationDbContext _context;
        public PlayerController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _context.Database.EnsureCreated();
            _enviromont = environment;
            
        }
        public IActionResult Index()
        {
            var players = _context.Players;
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var player = new Player();
            return View(player);
        }

        [HttpPost]
        public IActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                AddPlayer(player);
                return RedirectToAction("Index");
            }
            return View(player);
        }
        private void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public IActionResult Details(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            var path = _enviromont.WebRootPath;
            var file = Path.Combine($"{path}\\images", player.ImageLink);
            var fileExist = System.IO.File.Exists(file);
            ViewBag.FileExist = fileExist;
            return View(player);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            return View(player);
        }
        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            _context.Players.Remove(player);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var player = _context.Players.Where(x => x.PlayerId == id).FirstOrDefault();
            return View(player);
        }
        [HttpPost]
        public IActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                UpdatePlayer(player);
                return RedirectToAction("Index");
            }
            return View(player);
        }

        private void UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
        }
    }
}
