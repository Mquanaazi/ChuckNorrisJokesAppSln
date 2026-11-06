using ChuckNorrisJokesApp.ViewModels;

namespace ChuckNorrisJokesApp.Views;

public partial class JokesView : ContentPage
{
	public JokesView(JokesViewModel VM)
	{
		InitializeComponent();

        BindingContext = VM;

    }
}