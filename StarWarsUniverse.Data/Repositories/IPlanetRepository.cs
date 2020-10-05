using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Data.Repositories
{
    public interface IPlanetRepository
    {
        IList<Planet> GetAllPlanets();
    }
}
