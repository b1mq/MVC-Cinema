using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FilmController : Controller
    {
        FilmsContext db;
        public FilmController(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Film> films = await Task.Run(() => db.Films);
            return View(films);
        }
    }
}
