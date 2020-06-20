using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieScore.Core.Entities;

namespace MovieScore.Infrastructure.Data.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(e => e.Date).HasColumnType("datetime");

            builder.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Image)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Title)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
