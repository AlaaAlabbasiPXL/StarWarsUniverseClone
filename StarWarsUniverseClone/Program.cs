using Microsoft.EntityFrameworkCore;
using StarWarsUniverse.Data;
using StarWarsUniverse.Data.Repositories.Db;
using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsUniverseClone
{
    //Print all movies, including title, episode id and release date, and sort them by episode id.
    //    The code should use the MovieDbRepository to retrieve the data.
    internal class Program
    {
        private static StarWarsContext _context = new StarWarsContext();
        private static MovieDbRepository movieDbRepository = new MovieDbRepository(_context);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var movies = movieDbRepository.GetAllMovies();
            Console.WriteLine("=== Star Wars Movies ===");
            foreach (Movie movie in movies)
            {
                string movieResult;
                movieResult = String.Format("Episode {0} -  {1} \n \t Released  {2:d} \n \t ", movie.EpisodeId, movie.Title, movie.ReleaseDate);
                StringBuilder result = new StringBuilder(movieResult + "[");
                foreach (MoviePlanet mp in movie.MoviePlanets)
                {
                    result.Append("( "+ mp.Planet.Name +" ) ");
                }
                result.Append("]");
                Console.WriteLine(result.ToString());

            }
        }
    }
}
