using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uncivilized.ViewModels;

using Microsoft.AspNetCore.Identity;
using Uncivilized.Models;
using System.Security.Claims;

namespace Uncivilized.Controllers
{
    public class GameController : Controller
    {
        private UncivilizedDbContext db = new UncivilizedDbContext();

        private readonly UncivilizedDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public GameController(UserManager<User> userManager, SignInManager<User> signInManager, UncivilizedDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateNation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNation(Nation nation)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            
            nation.SetProperties();
            
            _db.Nations.Add(nation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateGameEvent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGameEvent(GameEvent gameEvent)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);

            _db.GameEvents.Add(gameEvent);
            _db.SaveChanges();
            return RedirectToAction("CreateGameEvent");
        }

        public IActionResult ChooseEvent()
        {
            var randomGameEvent = db.GameEvents.OrderBy(r => Guid.NewGuid()).Take(1); // One way to get a random List of results (the Take(1) is just getting 1 row) 
            return Json(randomGameEvent); // pass the results to the jQuery in JSON format

        }



    }
}
