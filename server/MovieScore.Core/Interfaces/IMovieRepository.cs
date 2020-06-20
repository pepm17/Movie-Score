using MovieScore.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieScore.Core.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMovies();
    }
}
