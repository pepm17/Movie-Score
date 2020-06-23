using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieScore.Core.Entities;

namespace MovieScore.Infrastructure.Data.Configuration
{
    public class ActorMovieConfiguration : IEntityTypeConfiguration<ActorMovie>
    {
        public void Configure(EntityTypeBuilder<ActorMovie> builder)
        {
            builder.ToTable("Actor_Movie");

            builder.HasOne(d => d.Actor)
                .WithMany(p => p.Movies)
                .HasForeignKey(d => d.IdActor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Actor_Movie_Actor");

            builder.HasOne(d => d.Movie)
                .WithMany(p => p.Actors)
                .HasForeignKey(d => d.IdMovie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Actor_Movie_Movie");
        }
    }
}
