using Microsoft.EntityFrameworkCore;
using MovieScore.Core.Entities;
using MovieScore.Core.Interfaces;
using MovieScore.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieScore.Infrastructure.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly MovieScoreContext _movieScoreContext;

        public ActorRepository(MovieScoreContext movieScoreContext)
        {
            _movieScoreContext = movieScoreContext;
        }

        public async Task<Actor> GetActor(int id)
        {
            var actor = await _movieScoreContext.Actor.FirstOrDefaultAsync(x => x.Id == id);
            return actor;
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            var actors = await _movieScoreContext.Actor.ToListAsync();
            return actors;
        }

        public async Task InsertActor(Actor actor)
        {
            _movieScoreContext.Add(actor);
            await _movieScoreContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateActor(Actor actor)
        {
            var currentActor = await GetActor(actor.Id);
            currentActor.Name = actor.Name;
            currentActor.Lastname = actor.Lastname;
            currentActor.Score = (actor.Score + currentActor.Score)/2;
            currentActor.Image = actor.Image;
            currentActor.Description = actor.Description;
            int rows = await _movieScoreContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteActor(int id)
        {
            var currentActor = await GetActor(id);
            _movieScoreContext.Remove(currentActor);
            var rows = await _movieScoreContext.SaveChangesAsync();
            return rows > 0;
        }
    }
}
