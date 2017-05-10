using System.Linq;

namespace BetaBit.DesignPatterns
{
    public sealed class SearchPageViewModel : PageViewModelBase
    {
        private readonly IItemsSource _itemsSource;
        private readonly ClientsClient _clientsClient;

        public SearchPageViewModel(ContainerViewModel container, IItemsSource itemsSource, ClientsClient clientsClient)
            : base(container)
        {
            _itemsSource = itemsSource;
            _clientsClient = clientsClient;

            SearchContext.UpdateSearchPage(this);
        }

        public ClaimId ClaimId { get; set; }
        public ClientId ClientId { get; set; }

        public void SearchClaim()
        {
            SearchContext = new ClaimSearchContext(ClaimId);
            Items = _itemsSource.GetItemsByClaim(ClaimId);
            Container.GotoEditPage();
        }

        public void SearchClient()
        {
            SearchContext = new ClientSearchContext(ClientId);
            var client = _clientsClient.GetClient(ClientId);
            var claimIds = client.Type.GetExternalClaimIds(client);
            Items = claimIds.SelectMany(_itemsSource.GetItemsByClaim);
            Container.GotoEditPage();
        }
    }
}
