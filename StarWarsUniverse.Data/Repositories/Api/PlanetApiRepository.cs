using Newtonsoft.Json;
using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace StarWarsUniverse.Data.Repositories.Api
{
    public class PlanetApiRepository : IPlanetRepository
    {
        private readonly HttpClient _httpClient;

        public PlanetApiRepository()
        {  //The URL itself should end with a slash (/), otherwise the API returns 
           //an error (301 Moved Permanently).
            _httpClient = new HttpClient { BaseAddress = new Uri("http://swapi.dev") };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add
                (
                new MediaTypeWithQualityHeaderValue("application/json")
                );
        }
        //https://swapi.dev/api/planets/

        public IList<Planet> GetAllPlanets()
        {
            var url = "/api/planets/";           //for lus voor request
            var allPlanets = new List<Planet>();
            string currentUrl = url;

            do
            {
                HttpResponseMessage response = _httpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result;
                    var resultsPage = JsonConvert.DeserializeObject<ResultsPage<Planet>>(content);  //for lus 

                    allPlanets.AddRange(resultsPage.Results);

                    currentUrl = resultsPage.Next;
                }
            } while (currentUrl != null);
             
            return allPlanets;

        }
    }
}
