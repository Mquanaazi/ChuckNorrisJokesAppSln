using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokesApp.Interfaces
{
    internal interface IPopUp
    {
        Task ShowingPopUp(string title, string message, string buttonText);
    }
}
