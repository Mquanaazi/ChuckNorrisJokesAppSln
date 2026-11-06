//using Android.App;
using ChuckNorrisJokesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ChuckNorrisJokesApp.ViewModels
{
    public class JokesViewModel: BaseViewModel
    {


        public ICommand GetJokeCommand { get; }
        public int ChuckNorrisJoke
        {
            get { return ChuckNorrisJoke; }
            set
            {
                ChuckNorrisJoke = value;
                OnPropertyChanged();
            }
        }

        private IChuckNorriesHttpApiService _chuckNorriesApiService;
        public JokesViewModel(IChuckNorriesHttpApiService service)

        {
            _chuckNorriesApiService = service;
            GetJokeCommand= new Command(FetchJoke);
        }
        private async void FetchJoke(object param)
        {
            await _chuckNorriesApiService.GetJokeAsync();
        }
    }
}
