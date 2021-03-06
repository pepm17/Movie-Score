﻿using System;
using System.Collections.Generic;

namespace MovieScore.Core.Entities
{
    public partial class Movie
    {
        public Movie()
        {
            Actors = new HashSet<ActorMovie>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Score { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<ActorMovie> Actors { get; set; }
    }
}
