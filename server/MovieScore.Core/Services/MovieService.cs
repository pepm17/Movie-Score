using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieScore.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await _movieRepository.GetMovie(id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _movieRepository.GetMovies();
        }

        public async Task InsertMovie(Movie movie)
        {
            await _movieRepository.InsertMovie(movie);
        }

        public async Task<bool> UpdateMovie(Movie movie)
        {
            return await _movieRepository.UpdateMovie(movie);
        }

        public async Task<bool> DeleteMovie(int id)
        {
            return await _movieRepository.DeleteMovie(id);
        }
    }
}
