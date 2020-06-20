using MovieScore.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieScore.Core.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(int id);
        Task InsertMovie(Movie movie);
    }
}
