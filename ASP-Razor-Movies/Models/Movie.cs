using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_Movies.Models
{
    public enum Genres
    {
        Comedy, Drama, Horror, Romance, Thriller, Family
    }

    /// <summary>
    /// Information that is required about each movie
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres Genre { get; set; }
        public decimal Price { get; set; }
    }
}
