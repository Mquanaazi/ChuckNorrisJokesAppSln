using ChuckNorrisJokesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokesApp.Services
{
    internal class MauiPopupService : IPopUp
    {
        public async Task ShowingPopUp(string title, string message, string buttonText)
        {
           await Shell.Current.DisplayAlertAsync(title,message, buttonText);
           
        }
    }
}
