using Newtonsoft.Json;
using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

//The code that will call the swapi makes use of the HttpClient-class, which is located in 
//    the namespace System.Net.Http and converts the JSON-string to objects using JsonConvert 
//    in Newtonsoft.Json.Both namespaces can be added without installing any additional NuGet 
//    packages.

namespace StarWarsUniverse.Data.Repositories.Api
{
    public class MovieApiRepository : IMovieRepository
    {
        private readonly HttpClient _httpClient;

        public MovieApiRepository()
        {  //The URL itself should end with a slash (/), otherwise the API returns 
           //an error (301 Moved Permanently).
            _httpClient = new HttpClient { BaseAddress = new Uri("http://swapi.dev") };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add
                (
                new MediaTypeWithQualityHeaderValue("application/json")
                );
        }

        //interface implementation
        public IList<Movie> GetAllMovies()
        {
            var url = "/api/films/";
            var allMovies = new List<Movie>();
            ResultsPage<Movie> resultsPage = null;

            HttpResponseMessage response = _httpClient.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                resultsPage = JsonConvert.DeserializeObject<ResultsPage<Movie>>(content);
                allMovies = resultsPage.Results;
            }
            return allMovies;
        }
    }
    internal class ResultsPage<T>
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<T> Results { get; set; }
    }
}