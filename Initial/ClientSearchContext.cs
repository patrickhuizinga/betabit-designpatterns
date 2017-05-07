namespace BetaBit.DesignPatterns
{
    public sealed class ClientSearchContext : ISearchContext
    {
        public string ClientId { get; }
        public string Title => $"Client {ClientId}";

        public ClientSearchContext(string clientId)
        {
            ClientId = clientId;
        }

        public void UpdateSearchPage(SearchPageViewModel searchPage)
        {
            searchPage.ClaimId = ClientId;
        }
    }
}
