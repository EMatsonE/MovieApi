using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Models;
using Flurl.Http;

namespace MovieApi.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        [HttpGet]
        public ActionResult Index()
        {
            string apiUri = "https://imdb-internet-movie-database-unofficial.p.rapidapi.com/film/hobbit";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "imdb-internet-movie-database-unofficial.p.rapidapi.com",
                x_rapidapi_key = "a5b04e6222mshe0376e842564881p134a29jsnd3f1bd79e8cc"
            }).GetJsonAsync<Movie>();

            apiTask.Wait();

            Movie movie = apiTask.Result;

            return View(movie);
        }
        [HttpPost]
        public IActionResult Index(string movieTitle = "hobbit")
        {
            string apiUri = $"https://imdb-internet-movie-database-unofficial.p.rapidapi.com/film/{movieTitle}";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "imdb-internet-movie-database-unofficial.p.rapidapi.com",
                x_rapidapi_key = "a5b04e6222mshe0376e842564881p134a29jsnd3f1bd79e8cc"
            }).GetJsonAsync<Movie>();

            apiTask.Wait();

            Movie movie = apiTask.Result;

            return View(movie);
        }


        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
