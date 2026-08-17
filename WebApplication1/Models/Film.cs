using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Film
    {
        [Key]
        public int Film_id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? Release_Year { get; set; }
        public string? Director { get; set; }
        public string? Language { get; set; }
        public string? Country { get; set; }
        public string? Genre { get; set; }
        public string? Poster_Url { get; set; }
        public decimal? Rating { get; set; }

    }
}
