using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Domain
{
    public class Planet : Resource
    {
        public string Name { get; set; }
        // Note: RotationPeriod, OrbitalPeriod and Diameter 
        // return sometimes "unknown" 
        // quick-fix -> use string types (instead of int) 
        // longer fix (Todo) -> change JSON deserialisation to substitute "unknown" with -1 

        //In Deserialization, it does the opposite of Serialization which means it converts JSON string to custom .Net object.

        [JsonProperty("rotation_period")] 
        public string RotationPeriod { get; set; }
        
        [JsonProperty("orbital_period")] 
        public string OrbitalPeriod { get; set; } 
        
        public string Diameter { get; set; } 
        public string Climate { get; set; }

        public string Gravity { get; set; }
        public string Terrain { get; set; }

        [JsonProperty("surface_water")] 
        public string SurfaceWater { get; set; }

        public string Population { get; set; }

        [JsonIgnore]
        public List<MoviePlanet> MoviePlanets { get; set; } = new List<MoviePlanet>();

        [JsonProperty(PropertyName = "films")]
        public List<string> MovieUris { get; set; }
    }
}
