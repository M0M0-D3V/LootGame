using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using LootGame.Models;
using Microsoft.EntityFrameworkCore;
using LootGame.Helpers;


namespace LootGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost("/NewGame")]
        public IActionResult NewGame()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Game");
        }
        // ********* HERE"S THE GAME*******************
        [HttpGet("/game")]
        public IActionResult Game()
        {
            Game currentGame = GetGameFromSession();
            // save game to session
            HttpContext.Session.SetObjectAsJson("currentGame", currentGame);
            // SessionHelper.SetObjectAsJson(HttpContext.Session, "currentGame", currentGame);
            //  if game is over, redirect game finished screen
            // if (currentGame.GameFinished())
            // {
            //     return RedirectToAction("GameComplete");
            // }
            // if game is NOT over, keep rendering the same board with updated stats
            return View(currentGame);
        }
        public Game GetGameFromSession()
        {
            Game currentGame = null;
            if (HttpContext.Session.GetObjectFromJson<Game>("currentGame") == null)
            {
                // create new game
                currentGame = new Game(NewGame: true);
                // All (2) players are dealt cards
            }
            else
            {
                currentGame = HttpContext.Session.GetObjectFromJson<Game>("currentGame");
            }
            return currentGame;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
