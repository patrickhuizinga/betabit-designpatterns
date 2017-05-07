namespace BetaBit.DesignPatterns
{
    public sealed class EditPageViewModel : PageViewModelBase
    {
        public EditPageViewModel(ContainerViewModel container)
            : base(container)
        {
        }

        public void GotoPrevious() => Container.GotoSearchPage();
        public void Close() => Container.CloseScreen();
    }
}
