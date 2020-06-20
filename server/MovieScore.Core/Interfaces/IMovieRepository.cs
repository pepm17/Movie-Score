using MovieScore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieScore.Core.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Pelicula>> GetMovies();
    }
}
