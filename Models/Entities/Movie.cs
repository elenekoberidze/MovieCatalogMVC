using System.ComponentModel.DataAnnotations;

namespace Imdb_418.Models.Entities
{
    public enum Genre
    {
        Drama, Comedy, SciFi, 
    }

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        [StringLength(100)]
        public string? Description { get; set; }

        [Required]
        public DateOnly ReleaseDate { get; set; }

        public Genre Genre { get; set; }
    }
}
