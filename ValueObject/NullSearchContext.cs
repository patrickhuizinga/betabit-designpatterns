namespace BetaBit.DesignPatterns
{
    public class NullSearchContext : ISearchContext
    {
        public string Title => "";
        public void UpdateSearchPage(SearchPageViewModel searchPage)
        {
        }
    }
}
