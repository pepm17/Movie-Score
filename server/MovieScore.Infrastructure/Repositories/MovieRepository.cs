using Microsoft.EntityFrameworkCore;
using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using MovieScore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScore.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieScoreContext _movieScoreContext;
        public MovieRepository(MovieScoreContext movieScoreContext)
        {
            _movieScoreContext = movieScoreContext;
        }
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = await _movieScoreContext.Movie.ToListAsync();
            return movies;
        }

        public async Task<Movie> GetMovie(int id)
        {
            var movie = await _movieScoreContext.Movie.FirstOrDefaultAsync(x=> x.Id == id);
            return movie;
        }

        public async Task InsertMovie(Movie movie)
        {
            _movieScoreContext.Movie.Add(movie);
            await _movieScoreContext.SaveChangesAsync();
        }
    }
}
