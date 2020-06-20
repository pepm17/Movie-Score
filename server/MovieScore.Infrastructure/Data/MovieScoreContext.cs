using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MovieScore.Core.Entities;

namespace MovieScore.Infrastructure.Data
{
    public partial class MovieScoreContext : DbContext
    {
        public MovieScoreContext()
        {
        }

        public MovieScoreContext(DbContextOptions<MovieScoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<ActorMovie> ActorMovie { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActorMovie>(entity =>
            {
                entity.ToTable("Actor_Movie");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdActorNavigation)
                    .WithMany(p => p.ActorMovie)
                    .HasForeignKey(d => d.IdActor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Actor_Movie_Actor");

                entity.HasOne(d => d.IdMovieNavigation)
                    .WithMany(p => p.ActorMovie)
                    .HasForeignKey(d => d.IdMovie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Actor_Movie_Movie");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false);
            });
        }
    }
}
