using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieScore.Core.Entities;

namespace MovieScore.Infrastructure.Data.Configuration
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

            builder.Property(e => e.Image)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Lastname)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
