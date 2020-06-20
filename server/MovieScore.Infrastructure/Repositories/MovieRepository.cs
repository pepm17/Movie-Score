using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScore.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public async Task<IEnumerable<Pelicula>> GetMovies()
        {
            var movies = Enumerable.Range(1, 10).Select(x => new Pelicula
            {
                Id = x,
                Title = $"Title {x}",
                Description = $"Description {x}",
                Image = $"Image {x}",
                Score = x,
                Date = DateTime.Now
            });
            await Task.Delay(10);
            return movies;
        }
    }
}
