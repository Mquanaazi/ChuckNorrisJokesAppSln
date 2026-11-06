using ChuckNorrisJokesApp.Interfaces;
using ChuckNorrisJokesApp.Models;
using Newtonsoft.Json;
using 
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChuckNorrisJokesApp.Services
{
    public class ChuckNorriesHttpApiService : IChuckNorriesApiService
    {
        private  IConfigurationService _configurationService;
        private HttpClient _httpClient;
        public ChuckNorriesHttpApiService(IConfigurationService configurationService)
        {
            _configurationService = configurationService;

            _httpClient = new HttpClient();



        }
        public async Task<string> GetJokeAsync()

        {
            HttpResponseMessage response = await _httpClient.GetAsync(_configurationService.ChuckNorrisApiUrl);
            //return _httpClient.GetStringAsync(_configurationService.ChuckNorrisApiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                ChuckNorrisJoke Joke = JsonConvert.DeserializeObject(jsonContent) as ChuckNorrisJoke;

                if (Joke != null)
                {
                    return Joke.value;
                }
                else
                {
                    return "No joke found.";
                }
            }
            return null;

        }



    }
}
