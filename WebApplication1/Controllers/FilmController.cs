using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Контроллер для управления фильмами (Film).
    /// Обеспечивает выполнение базовых CRUD-операций: просмотр списка, редактирование, удаление и просмотр деталей фильма.
    /// </summary>
    public class FilmController : Controller
    {
        private readonly FilmContext _db;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FilmController"/>.
        /// </summary>
        /// <param name="db">Контекст базы данных Entity Framework для работы с таблицей фильмов.</param>
        public FilmController(FilmContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Асинхронно получает список всех фильмов и отображает главную страницу.
        /// </summary>
        /// <returns>Представление (View) с коллекцией всех фильмов.</returns>
        public async Task<IActionResult> Index()
        {
            IEnumerable<Film> films = await Task.Run(() => _db.films);
            return View(films);
        }

        /// <summary>
        /// Удаляет фильм из базы данных по его идентификатору.
        /// </summary>
        /// <param name="id">Уникальный идентификатор удаляемого фильма.</param>
        /// <returns>Перенаправление на главную страницу (метод <see cref="Index"/>).</returns>
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

        /// <summary>
        /// Отображает форму для редактирования существующего фильма.
        /// </summary>
        /// <param name="id">Уникальный идентификатор фильма, который нужно отредактировать.</param>
        /// <returns>Представление с формой редактирования, если фильм найден; иначе возвращает ошибку 404 (NotFound).</returns>
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

        /// <summary>
        /// Обрабатывает отправленную форму и сохраняет обновленные данные фильма в базу данных.
        /// </summary>
        /// <param name="film">Модель фильма с обновленными данными, полученными из формы.</param>
        /// <returns>Перенаправление на главную страницу (метод <see cref="Index"/>) после успешного сохранения.</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(Film film)
        {
             _db.films.Update(film);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Отображает страницу с детальной информацией о конкретном фильме.
        /// </summary>
        /// <param name="id">Уникальный идентификатор фильма для просмотра.</param>
        /// <returns>Представление 'MoviePage' с деталями фильма, если он найден; иначе возвращает ошибку 404 (NotFound).</returns>
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
