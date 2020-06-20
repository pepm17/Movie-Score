using System;
using System.Collections.Generic;

namespace MovieScore.Core.Entities
{
    public partial class ActorMovie
    {
        public int Id { get; set; }
        public int IdActor { get; set; }
        public int IdMovie { get; set; }

        public virtual Actor IdActorNavigation { get; set; }
        public virtual Movie IdMovieNavigation { get; set; }
    }
}
