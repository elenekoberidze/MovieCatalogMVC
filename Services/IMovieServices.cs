using Imdb_418.Models.Entities;

namespace Imdb_418.Services
{
    public interface IMovieServices
    {
        /// <summary>
        /// This method adds new movie
        /// </summary>
        Task CreateMovieAsync(Movie movie);
        /// <summary>
        /// This method gets all movies
        /// </summary>
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        /// <summary>
        /// This method gets movies by id
        /// </summary>
        Task<Movie> GetMovieByIdAsync(int id);
        /// <summary>
        /// This method updates movie
        /// </summary>
        Task<bool> UpdateMovieAsync(int id, Movie movie);
        /// <summary>
        /// This method deletes movie
        /// </summary>
        Task<bool> DeleteMovieByIdAsync(int id);
    }
}
