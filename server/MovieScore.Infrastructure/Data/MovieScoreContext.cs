using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MovieScore.Core.Entities;
using MovieScore.Infrastructure.Data.Configuration;

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieScoreContext).Assembly);
            //modelBuilder.ApplyConfiguration(new ActorConfiguration());
            //modelBuilder.ApplyConfiguration(new ActorMovieConfiguration());
            //modelBuilder.ApplyConfiguration(new MovieConfiguration());
        }
    }
}
