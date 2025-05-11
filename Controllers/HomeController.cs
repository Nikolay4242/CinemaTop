using Microsoft.AspNetCore.Mvc;
using CinemaProject.Models;
using System.Collections.Generic;

namespace CinemaProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var todaySessions = MoviesController.GetAllSessions()
                .Where(s => s.Date.Date == DateTime.Today)
                .OrderBy(s => s.Time)
                .ToList();

            return View(todaySessions);
        }


    }
}
