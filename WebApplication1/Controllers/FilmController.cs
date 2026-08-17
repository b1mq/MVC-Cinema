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
            IEnumerable<Film> films = await Task.Run(() => _db.Films);
            return View(films);
        }
    }
}
