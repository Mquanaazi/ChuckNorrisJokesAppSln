using ChuckNorrisJokesApp.Interfaces;
using ChuckNorrisJokesApp.Services;
using ChuckNorrisJokesApp.ViewModels;
using ChuckNorrisJokesApp.Views;
using Microsoft.Extensions.Logging;

namespace ChuckNorrisJokesApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IConfigurationService, ConfigurationServices>();
            builder.Services.AddSingleton<IChuckNorriesApiService, ChuckNorriesHttpApiService>();
            
            builder.Services.AddTransient<JokesViewModel>();
            builder.Services.AddTransient<JokesView>();

            return builder.Build();
        }
    }
}
