namespace BetaBit.DesignPatterns
{
    public sealed class SearchPageViewModel : PageViewModelBase
    {
        private readonly ItemsClient _itemsClient;

        public SearchPageViewModel(ContainerViewModel container, ItemsClient itemsClient)
            : base(container)
        {
            _itemsClient = itemsClient;

            SearchContext.UpdateSearchPage(this);
        }

        public string ClaimId { get; set; }
        public string ClientId { get; set; }

        public void SearchClaim()
        {
            SearchContext = new ClaimSearchContext(ClaimId);
            Items = _itemsClient.GetItemsByClaim(ClaimId);
            Container.GotoEditPage();
        }

        public void SearchClient()
        {
            SearchContext = new ClientSearchContext(ClientId);
            Items = _itemsClient.GetItemsByClient(ClientId);
            Container.GotoEditPage();
        }
    }
}
