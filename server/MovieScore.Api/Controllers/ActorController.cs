using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieScore.Api.Responses;
using MovieScore.Core.DTOs;
using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;

namespace MovieScore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IActorService _actorService;

        public ActorController(IMapper mapper, IActorService actorService)
        {
            _mapper = mapper;
            _actorService = actorService;
        }

        [HttpGet]
        public async Task<ActionResult> GetActors()
        {
            var actors = await _actorService.GetActors();
            var actorsDto = _mapper.Map<IEnumerable<ActorDto>>(actors);
            var response = new ApiResponse<IEnumerable<ActorDto>>(actorsDto);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetActor(int id)
        {
            var actor = await _actorService.GetActor(id);
            var actorDto = _mapper.Map<ActorDto>(actor);
            var response = new ApiResponse<ActorDto>(actorDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> InsertActor(ActorDto actorDto)
        {
            var actor = _mapper.Map<Actor>(actorDto);
            await _actorService.InsertActor(actor);
            actorDto.Id = actor.Id;
            var response = new ApiResponse<ActorDto>(actorDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateActor(int id, ActorDto actorDto)
        {
            var actor = _mapper.Map<Actor>(actorDto);
            actor.Id = id;
            var result = await _actorService.UpdateActor(actor);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteActor(int id)
        {
            var result = await _actorService.DeleteActor(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
