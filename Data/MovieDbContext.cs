using Imdb_418.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imdb_418.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MovieDbContext()
        {
        }

        public DbSet <Movie> Movie { get; set; }
    }
}
