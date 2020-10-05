using Newtonsoft.Json;    //library for serializing objects from/to JSON strings.
using System;

namespace StarWarsUniverse.Domain
{
    public class Resource
    {
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        [JsonProperty(PropertyName = "url")] //[JsonProperty(PropertyName = "url")] maps the json attribute url to the property Uri
        public string Uri { get; set; }

    }
}
