using ChuckNorrisJokesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokesApp.Services
{
    public class ChuckNorriesHttpApiService : IChuckNorriesApiService
    {
        private  IConfigurationService _configurationService;
        public ChuckNorriesHttpApiService(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }
    }
}
