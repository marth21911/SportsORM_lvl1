using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.HockeyLeagues = _context.Leagues
            .Where(l => l.Name.Contains("Hockey"))
            .ToList();
            ViewBag.WomensLeagues = _context.Leagues
            .Where(l => l.Name.Contains("Womens'"))
            .ToList();
            ViewBag.nonFootball = _context.Leagues
            .Where(l => !l.Name.Contains("Football"))
            .ToList();
            ViewBag.Conferences = _context.Leagues
            .Where(l => l.Name.Contains("Conference"))
            .ToList();
            ViewBag.Atlantic = _context.Leagues
            .Where(l => l.Name.Contains("Atlantic"))
            .ToList();
            ViewBag.DallasTeams = _context.Teams
            .Where(l => l.Location.Contains("Dallas"))
            .ToList();
            ViewBag.Raptors = _context.Teams
            .Where(l => l.TeamName.Contains("Raptors"))
            .ToList();
            ViewBag.CityTeams = _context.Teams
            .Where(l => l.Location.Contains("City"))
            .ToList();
            ViewBag.startsWithT = _context.Teams
            .Where(l => l.TeamName.Contains("T"))
            .ToList();
            ViewBag.alphaLocation = _context.Teams
            .OrderBy(l => l.Location)
            .ToList();
            ViewBag.reverseAlphaTeam = _context.Teams
            .OrderByDescending(l => l.TeamName)
            .ToList();
            ViewBag.Coopers = _context.Players
            .Where(l => l.LastName.Contains("Cooper"))
            .ToList();
            ViewBag.Josh = _context.Players
            .Where(l => l.FirstName.Contains("Joshua"))
            .ToList();
            ViewBag.notJosh = _context.Players
            .Where(l => l.LastName.Contains("Cooper")).Where(l => !l.FirstName.Contains("Joshua"))
            .ToList();
            ViewBag.dudes = _context.Players
            .Where(l => l.FirstName == "Alexander"|| l.FirstName =="Wyatt")
            .ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}