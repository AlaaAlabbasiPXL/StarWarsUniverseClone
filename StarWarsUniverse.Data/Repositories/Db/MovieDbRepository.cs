using Microsoft.EntityFrameworkCore;
using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsUniverse.Data.Repositories.Db
{
    public class MovieDbRepository : IMovieRepository
    {
        private readonly StarWarsContext _starWarsContext;
        public MovieDbRepository(StarWarsContext starWarsContext)
        {
            _starWarsContext = starWarsContext;
        }

        public IList<Movie> GetAllMovies()
        {
            //return _starWarsContext.Movies.ToList();
            return _starWarsContext.Movies.Include(m => m.MoviePlanets)
                .ThenInclude(mp => mp.Planet)
                .OrderBy(m => m.EpisodeId).ToList();
            //Include specifies to load related entities in the result query, 
            //accordingly will ThenInclude add further related entities in the relationship
        }
    }
}
