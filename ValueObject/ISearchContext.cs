namespace BetaBit.DesignPatterns
{
    public interface ISearchContext
    {
        string Title { get; }
        void UpdateSearchPage(SearchPageViewModel searchPage);
    }
}
