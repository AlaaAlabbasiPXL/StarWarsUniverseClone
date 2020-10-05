using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsUniverse.Domain
{
    public class Movie : Resource
    {
        public string Title { get; set; }

        [JsonProperty(PropertyName = "episode_id")]//[JsonProperty(PropertyName = "episode_id")] maps the json attribute url to the property EpisodeId
        public int EpisodeId { get; set; }

        [JsonProperty(PropertyName = "opening_crawl")]
        public string OpeningCrawl { get; set; }

        public string Director { get; set; }
        public string Producer { get; set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTime ReleaseDate { get; set; }


        //Property MoviePlanets acts as a navigation property so you can retrieve all planets for a given movie.
        //These planets are fetched from swapi and stored in PlanetUris.

       [JsonIgnore] 
        public List<MoviePlanet> MoviePlanets { get; set; } = new List<MoviePlanet>();
        
        [JsonProperty(PropertyName = "planets")] 
        public List<string> PlanetUris { get; set; }
    }
}
