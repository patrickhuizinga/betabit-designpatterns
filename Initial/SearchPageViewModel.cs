using System.Linq;

namespace BetaBit.DesignPatterns
{
    public sealed class SearchPageViewModel : PageViewModelBase
    {
        private readonly ItemsClient _itemsClient;
        private readonly ClientsClient _clientsClient;

        public SearchPageViewModel(ContainerViewModel container, ItemsClient itemsClient, ClientsClient clientsClient)
            : base(container)
        {
            _itemsClient = itemsClient;
            _clientsClient = clientsClient;

            if (SearchContext != null)
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
            var client = _clientsClient.GetClient(ClientId);
            switch (client.Type)
            {
                    case ClientType.Consumer:
                        Items = client.ClaimIds.SelectMany(_itemsClient.GetItemsByClaim);
                        break;
                    case ClientType.Business:
                        Items = client.ClaimIds.Where(ci => !ci.StartsWith("123")).SelectMany(_itemsClient.GetItemsByClaim);
                        break;
            }
            Container.GotoEditPage();
        }
    }
}
