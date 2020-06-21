using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieScore.Core.DTOs;
using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieScore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movies;
        private readonly IMapper _mapper;
        public MovieController(IMovieRepository movies, IMapper mapper)
        {
            _movies = movies;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovie()
        {
            var movies = await _movies.GetMovies();
            var moviesDtos = _mapper.Map<IEnumerable<MovieDto>>(movies);
            return Ok(moviesDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _movies.GetMovie(id);
            var moviesDtos =  _mapper.Map<IEnumerable<MovieDto>>(movie);
            return Ok(moviesDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Movie(MovieDto movieDto)
        {
            var movie = _mapper.Map<Movie>(movieDto);
            await _movies.InsertMovie(movie);
            return Ok(movie);
        }
    }
}
