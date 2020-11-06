using _10_IntroToAPIs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs.Services
{
    public class MySwapiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string baseUrl = "https://us-central1-lateral-incline-114906.cloudfunctions.net/swapi/";

        public async Task<Character> GetCharacterAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "people/" + id);

            if (response.IsSuccessStatusCode)
            {
                Character character = await response.Content.ReadAsAsync<Character>();
                return character;
            }

            return null;
        }

        public async Task PostCharacterAsync(Character character)
        {
            string json = JsonConvert.SerializeObject(character);

            HttpContent data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(baseUrl + "people/", data);

            // string result = response.Content.ReadAsStringAsync().Result;
            // return result;
        }

        public async Task<CharacterWithHomeworld> GetCharacterWithHomeworldAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "people/" + id);

            if (response.IsSuccessStatusCode)
            {
                Character character = await response.Content.ReadAsAsync<Character>();
                CharacterWithHomeworld characterWithHomeworld = new CharacterWithHomeworld()
                {
                    Name = character.Name,
                    HomeworldId = character.Homeworld,
                    Gender = character.Gender
                };

                HttpResponseMessage planetResponse = await _httpClient.GetAsync(baseUrl + "planets/" + character.Homeworld);

                if (planetResponse.IsSuccessStatusCode)
                {
                    Planet homeworld = await planetResponse.Content.ReadAsAsync<Planet>();
                    characterWithHomeworld.Homeworld = homeworld;
                }
                else
                {
                    characterWithHomeworld.Homeworld = null;
                }


                return characterWithHomeworld;
            }

            return null;
        }

        public async Task<Planet> GetPlanetAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(baseUrl + "planets/" + id);

            if (response.IsSuccessStatusCode)
            {
                Planet planet = await response.Content.ReadAsAsync<Planet>();
                return planet;
            }

            return null;
        }
    }
}
