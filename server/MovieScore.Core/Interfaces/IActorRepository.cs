using MovieScore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieScore.Core.Interfaces
{
    public interface IActorRepository
    {
        Task<IEnumerable<Actor>> GetActors();
        Task<Actor> GetActor(int id);
        Task InsertActor(Actor actor);
        Task<bool> UpdateActor(Actor actor);
        Task<bool> DeleteActor(int id);
    }
}
