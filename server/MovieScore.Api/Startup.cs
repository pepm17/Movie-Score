using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieScore.Core.Interfaces;
using MovieScore.Core.Services;
using MovieScore.Infrastructure.Data;
using MovieScore.Infrastructure.Filters;
using MovieScore.Infrastructure.Repositories;
using System;

namespace MovieScore.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();

            services.AddDbContext<MovieScoreContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("MovieScore"))
            );

            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IActorRepository, ActorRepository>();
            services.AddTransient<IActorService, ActorService>();

            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            }).AddFluentValidation(options => {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
