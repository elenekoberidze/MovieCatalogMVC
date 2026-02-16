using Imdb_418.Data;
using Imdb_418.Models.Entities;
using Imdb_418.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Imdb_418.Controllers
{
    public class MovieController(IMovieServices service) : Controller
    {
        private readonly IMovieServices service = service;

        public async Task<IActionResult> Index()
        {
            return View(await service.GetAllMoviesAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            await service.CreateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var movie = await service.GetMovieByIdAsync(id);
            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Movie movie)
        {
            await service.UpdateMovieAsync(movie.Id, movie);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await service.GetMovieByIdAsync(id);
            return View(movie);   
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await service.DeleteMovieByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
