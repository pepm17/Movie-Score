namespace MovieScore.Core.Entities
{
    public partial class ActorMovie
    {
        public int Id { get; set; }
        public int IdActor { get; set; }
        public int IdMovie { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
