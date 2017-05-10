namespace BetaBit.DesignPatterns
{
    public sealed class ContainerViewModel
    {
        private readonly ItemsClient _itemsClient;
        private readonly ClientsClient _clientsClient;
        public Data Data { get; }
        public PageViewModelBase CurrentPage { get; private set; }

        public ContainerViewModel(ItemsClient itemsClient, ClientsClient clientsClient)
        {
            _itemsClient = itemsClient;
            _clientsClient = clientsClient;
            Data = new Data();
            GotoSearchPage();
        }

        public void GotoSearchPage() => CurrentPage = new SearchPageViewModel(this, _itemsClient, _clientsClient);
        public void GotoEditPage() => CurrentPage = new EditPageViewModel(this);

        public void CloseScreen()
        {
        }
    }
}
