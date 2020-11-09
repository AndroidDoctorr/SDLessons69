using _10_IntroToAPIs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _10_IntroToAPIs.Services
{
    public class MySwapiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        // The API is here:
        private readonly string baseUrl = "https://us-central1-lateral-incline-114906.cloudfunctions.net/swapi/";
        // The API is on the Back End, meaning the server where the data is hosted.
        // The Front End is on my computer. This Console App is the Front End
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

        public async Task<HttpStatusCode> PostCharacterAsync(Character character)
        {
            Dictionary<string, string> characterData = new Dictionary<string, string>
            {
                { "name", character.Name },
                { "gender", character.Gender },
                { "homeworld", character.Homeworld.ToString() }
            };
            HttpContent content = new FormUrlEncodedContent(characterData);
            HttpResponseMessage response = await _httpClient.PostAsync(baseUrl + "people/", content);
            return response.StatusCode;
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
