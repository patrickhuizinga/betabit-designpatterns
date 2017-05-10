namespace BetaBit.DesignPatterns
{
    public sealed class ClientSearchContext : ISearchContext
    {
        public ClientId ClientId { get; }
        public string Title => $"Client {ClientId}";

        public ClientSearchContext(ClientId clientId)
        {
            ClientId = clientId;
        }

        public void UpdateSearchPage(SearchPageViewModel searchPage)
        {
            searchPage.ClientId = ClientId;
        }
    }
}
