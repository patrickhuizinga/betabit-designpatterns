namespace BetaBit.DesignPatterns
{
    public sealed class ContainerViewModel
    {
        private readonly ItemsClient _itemsClient;
        public Data Data { get; }
        public PageViewModelBase CurrentPage { get; private set; }

        public ContainerViewModel(ItemsClient itemsClient)
        {
            _itemsClient = itemsClient;
            Data = new Data();
            GotoSearchPage();
        }

        public void GotoSearchPage() => CurrentPage = new SearchPageViewModel(this, _itemsClient);
        public void GotoEditPage() => CurrentPage = new EditPageViewModel(this);

        public void CloseScreen()
        {
        }
    }
}
