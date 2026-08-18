using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models;
namespace WebApplication1.Services
{
    public class FinderService:IFinderService
    {
        public string Api = "https://www.omdbapi.com/?i=tt3896198&apikey=5c15d396";
        private readonly HttpClient _httpClient;
        public FinderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Film> GetFinderAsync(string movie)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{Api}&t={Uri.EscapeDataString(movie)}";
            var response = await _httpClient.GetFromJsonAsync<Film>(url,options);
            if(response != null)
            {
                return response;
            }else
            {
                return new Film {Title = "Not found" };
            }
            

        }
    }
}
