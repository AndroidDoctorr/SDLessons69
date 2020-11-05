using _10_IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string baseUrl = "https://swapi.dev/api/";

        public async Task<Person> GetPersonAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "people/" + id);

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            return null;
        }
    }
}
