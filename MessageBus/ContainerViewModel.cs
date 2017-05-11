namespace BetaBit.DesignPatterns
{
    public sealed class ContainerViewModel
    {
        private readonly IItemsSource _itemsSource;
        private readonly ClientsClient _clientsClient;
        private readonly MessageBus _messageBus;
        public Data Data { get; }
        public PageViewModelBase CurrentPage { get; private set; }

        public ContainerViewModel(IItemsSource itemsSource, ClientsClient clientsClient, MessageBus messageBus)
        {
            _itemsSource = itemsSource;
            _clientsClient = clientsClient;
            _messageBus = messageBus;
            Data = new Data { SearchContext = new NullSearchContext() };
            GotoSearchPage();
        }

        public void GotoSearchPage() => CurrentPage = new SearchPageViewModel(this, _itemsSource, _clientsClient);
        public void GotoEditPage() => CurrentPage = new EditPageViewModel(this);

        public void CloseScreen()
        {
            foreach (var item in Data.Items)
            {
                _messageBus.Publish(
                    new ItemAccessMessage { Item = item });
            }
        }
    }
}
