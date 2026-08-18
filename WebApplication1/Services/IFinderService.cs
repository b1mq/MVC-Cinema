namespace WebApplication1.Services
{
    using WebApplication1.Models;
    public interface IFinderService
    {
        public Task<Film> GetFinderAsync(string name);
    }
}
