using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieScore.Api.Responses;
using MovieScore.Core.DTOs;
using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieScore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        public MovieController(IMovieService movies, IMapper mapper)
        {
            _movieService = movies;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovie()
        {
            var movies = await _movieService.GetMovies();
            var moviesDtos = _mapper.Map<IEnumerable<MovieDto>>(movies);
            var response = new ApiResponse<IEnumerable<MovieDto>>(moviesDtos);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _movieService.GetMovie(id);
            var movieDto =  _mapper.Map<MovieDto>(movie);
            var response = new ApiResponse<MovieDto>(movieDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Movie(MovieDto movieDto)
        {
            var movie = _mapper.Map<Movie>(movieDto);
            await _movieService.InsertMovie(movie);
            movieDto.Id = movie.Id;
            var response = new ApiResponse<MovieDto>(movieDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> PutMovie(int id, MovieDto movieDto)
        {
            var movie = _mapper.Map<Movie>(movieDto);
            movie.Id = id;
            var result = await _movieService.UpdateMovie(movie);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var result = await _movieService.DeleteMovie(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
