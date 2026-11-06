using ChuckNorrisJokesApp.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokesApp.ViewModels
{
    public class JokesViewModel
    {
       private IChuckNorriesApiService _chuckNorriesApiService;
        public JokesViewModel(IChuckNorriesApiService service)

        {
            _chuckNorriesApiService = service;
        }
    }
}
