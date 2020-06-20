using System;

namespace MovieScore.Core.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Score { get; set; }

        public DateTime Date { get; set; }
    }
}
