namespace ChuckNorrisJokesApp.Interfaces
{
    public interface IChuckNorriesHttpApiService
    {
        Task<string> GetJokeAsync();
    }
}