using System.Collections.Generic;

namespace MovieScore.Core.Entities
{
    public partial class Actor
    {
        public Actor()
        {
            Movies = new HashSet<ActorMovie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }

        public virtual ICollection<ActorMovie> Movies { get; set; }
    }
}
