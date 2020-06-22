using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieScore.Core.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public async Task<Actor> GetActor(int id)
        {
           return await _actorRepository.GetActor(id);
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            return await _actorRepository.GetActors();
        }

        public async Task InsertActor(Actor actor)
        {
            await _actorRepository.InsertActor(actor);
        }

        public async Task<bool> UpdateActor(Actor actor)
        {
            return await _actorRepository.UpdateActor(actor);
        }

        public async Task<bool> DeleteActor(int id)
        {
            return await _actorRepository.DeleteActor(id);
        }
    }
}
