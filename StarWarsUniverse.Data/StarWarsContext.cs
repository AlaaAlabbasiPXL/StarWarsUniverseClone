using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StarWarsUniverse.Data.Repositories.Api;
using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWarsUniverse.Data
{
    public class StarWarsContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Planet> Planets { get; set; }


        public StarWarsContext() { }
        public StarWarsContext(DbContextOptions<StarWarsContext> options) 
            : base(options) 
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StarWarsDB;Trusted_Connection=True;");

            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = StarWarsDB; Trusted_Connection = True; "); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // define ResourceUri to be PK using Fluent API.
            modelBuilder.Entity<Movie>().HasKey(m => m.Uri);

            modelBuilder.Entity<Planet>().HasKey(p => p.Uri);


            //Once you added the entity objects via the HasData - method, you create a new 
            //migration which uses this info to create code to populate the database.

            IList<Movie> remoteMovies = new MovieApiRepository().GetAllMovies(); 
            modelBuilder.Entity<Movie>().HasData(remoteMovies.ToArray());

          // seed data code to fetch all planets in order to store them in the Planets table.
            IList<Planet> remotePlanets = new PlanetApiRepository().GetAllPlanets(); 
            modelBuilder.Entity<Planet>().HasData(remotePlanets.ToArray());

            //This makes sure list of Uris won’t be mapped in the database tables(it makes no sense because it 
            //duplicates the data in MoviePlanet).
            modelBuilder.Entity<Movie>().Ignore(movie => movie.PlanetUris); 
            modelBuilder.Entity<Planet>().Ignore(planet => planet.MovieUris);

            //to define primary keys in MoviePlanet and thus create the many to many relationship
            modelBuilder.Entity<MoviePlanet>().HasKey(moviePlanet => new { moviePlanet.MovieUri, moviePlanet.PlanetUri });

            //Finally you will have to add code to seed the MoviePlanets table. For every movie, look into every planet 
            //    and if a planet appears in the movie, add a new MoviePlanet object.
            //    You only have to fill out MovieUri and PlanetUri: 
            
            // this code needs to be placed in a nested loop
            foreach(Movie movie in remoteMovies)
            {
                foreach(Planet planet in remotePlanets)
                {
                    //Property MoviePlanets acts as a navigation property so you can retrieve all planets for a given movie.
                    //These planets are fetched from swapi and stored in PlanetUris.
                    if (movie.PlanetUris.Contains(planet.Uri))
                    {
                        modelBuilder.Entity<MoviePlanet>().HasData(new MoviePlanet() { MovieUri = movie.Uri, PlanetUri = planet.Uri });
                    }
                }
            }
            
        }
    }
}
