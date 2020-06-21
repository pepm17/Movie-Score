using AutoMapper;
using MovieScore.Core.DTOs;
using MovieScore.Core.Entities;

namespace MovieScore.Infrastructure.Mappings
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
        }
    }
}
