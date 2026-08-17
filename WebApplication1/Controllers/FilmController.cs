using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmContext _db;
        public FilmController(FilmContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Film> films = await Task.Run(() => _db.films);
            return View(films);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var filmToRemove = await _db.films.FindAsync(id);
            Console.WriteLine(filmToRemove);
            if(filmToRemove != null)
            {
                _db.films.Remove(filmToRemove);
                await _db.SaveChangesAsync();

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var film = await _db.films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            } 
            return View("~/Views/Home/Index.cshtml",film);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Film film)
        {
             _db.films.Update(film);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> More(int id)
        {
            var film = await _db.films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            return View("MoviePage",film);
        }

      
    }
}
