using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokesApp.Interfaces
{
    public interface IConfigurationService 
    {
        //string ChuckNorrisApiUrl { get; }

        Task<string> GetJokesAsync();
    }
}
