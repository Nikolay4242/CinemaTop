using Microsoft.AspNetCore.Mvc;
using CinemaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaProject.Controllers
{
    public class MoviesController : Controller
    {
        private static readonly List<Movie> _movies = new List<Movie>
        {
            new Movie
            {
                Title = "Крепкий орешек",
                Director = "Джон Мактирнан",
                Year = 1988,
                Description = "Офицер полиции Джон МакКлейн сражается с террористами в небоскрёбе Лос-Анджелеса.",
                Sessions = new List<Session>
                {
                    new Session { Date = DateTime.Today, Time = "18:00", MovieTitle = "Крепкий орешек", Price = 250 },
                    new Session { Date = DateTime.Today, Time = "21:00", MovieTitle = "Крепкий орешек", Price = 300 }
                }
            },
            new Movie
            {
                Title = "Хищник",
                Director = "Джон Мактирнан",
                Year = 1987,
                Description = "Отряд спецназа в джунглях сталкивается с инопланетным охотником.",
                Sessions = new List<Session>
                {
                    new Session { Date = DateTime.Today.AddDays(1), Time = "19:00", MovieTitle = "Хищник", Price = 270 }
                }
            },
            new Movie
            {
                Title = "Терминатор 2: Судный день",
                Director = "Джеймс Кэмерон",
                Year = 1991,
                Description = "Киборг из будущего должен защитить мальчика — ключ к выживанию человечества.",
                Sessions = new List<Session>
                {
                    new Session { Date = DateTime.Today.AddDays(2), Time = "20:30", MovieTitle = "Терминатор 2: Судный день", Price = 290 }
                }
            },
            new Movie
            {
                Title = "Кикбоксер",
                Director = "Марк ДиСалле",
                Year = 1989,
                Description = "Брат бойца проигрывает на турнире в Таиланде — и начинается путь мести.",
                Sessions = new List<Session>
                {
                    new Session { Date = DateTime.Today.AddDays(1), Time = "17:00", MovieTitle = "Кикбоксер", Price = 220 }
                }
            }
        };

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Details(string title)
        {
            var movie = _movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie == null)
                return NotFound();

            return View(movie);
        }

        // Этот метод пригодится для главной страницы
        public static List<Session> GetAllSessions()
        {
            return _movies.SelectMany(m => m.Sessions).ToList();
        }
    }
}
