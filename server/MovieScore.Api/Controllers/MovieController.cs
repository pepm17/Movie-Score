using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieScore.Core.Interfaces;
using MovieScore.Infrastructure.Repositories;

namespace MovieScore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movies;
        public MovieController(IMovieRepository movies)
        {
            _movies = movies;
        }
        [HttpGet]
        public async Task<IActionResult> GetMovie()
        {
            var movies = await _movies.GetMovies();
            return Ok(movies);
        }
    }
}
