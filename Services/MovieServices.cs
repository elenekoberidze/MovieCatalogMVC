using Imdb_418.Data;
using Imdb_418.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imdb_418.Services
{
    public class MovieServices(MovieDbContext context) : IMovieServices
    {
        private readonly MovieDbContext context = context;
        /// <inheritdoc/>
        public async Task CreateMovieAsync(Movie movie)
        {
            await context.Movie.AddAsync(movie);
            await context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await context.Movie.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movie = await context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            return movie ?? throw new Exception("Movie not found");
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateMovieAsync(int id, Movie movie)
        {
            var existingMovie = await context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (existingMovie == null)
            { return false; }

            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.ReleaseDate = movie.ReleaseDate;
            existingMovie.Genre = movie.Genre;
            await context.SaveChangesAsync();
            return true;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteMovieByIdAsync(int id)
        {
            var movie = await context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            { return false; }

            context.Movie.Remove(movie);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
