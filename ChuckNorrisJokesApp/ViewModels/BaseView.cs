using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChuckNorrisJokesApp.ViewModels
{
    public class BaseView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public abstract class BaseViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler? PropertyChanged;


            public virtual Task OnAppearingAsync()
            {
                return Task.CompletedTask;
            }

            public virtual Task OnDisappearingAsync()
            {
                return Task.CompletedTask;
            }

            protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}