using Microsoft.EntityFrameworkCore;
using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using MovieScore.Infrastructure.Data;
using System.Collections.Generic;
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
            var movies = await _movieScoreContext.Movie.Include(c => c.Actors)
                .ThenInclude(cs => cs.Actor).ToListAsync();
            return movies;
        }

        public async Task<Movie> GetMovie(int id)
        {
            var movie = await _movieScoreContext.Movie.Include(c=> c.Actors)
                .ThenInclude(cs => cs.Actor).FirstOrDefaultAsync(x=> x.Id == id || x.Title.Equals(id));
            return movie;
        }

        public async Task InsertMovie(Movie movie)
        {
            _movieScoreContext.Movie.Add(movie);
            await _movieScoreContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateMovie(Movie movie)
        {
            var currentMovie = await GetMovie(movie.Id);
            currentMovie.Title = movie.Title;
            currentMovie.Description = movie.Description;
            currentMovie.Image = movie.Image;
            currentMovie.Score = (movie.Score + currentMovie.Score)/2;
            currentMovie.Date = movie.Date;
            int rows = await _movieScoreContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteMovie(int id)
        {
            var currentMovie = await GetMovie(id);
            _movieScoreContext.Remove(currentMovie);
            int rows = await _movieScoreContext.SaveChangesAsync();
            return rows > 0;
        }
    }
}
