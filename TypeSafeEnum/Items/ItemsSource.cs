namespace BetaBit.DesignPatterns
{
    public static class ItemsSource
    {
        public static IItemsSource DefaultClient()
        {
            IItemsSource itemsSource = null; // connect with service somehow

            // if featureflag items caching is on
            itemsSource = new CachingItemsSource(itemsSource);

            var retries = 2; // get from config
            itemsSource = new RetryingItemsSource(itemsSource, retries);

            return itemsSource;
        }

        public static IItemsSource DefaultService()
        {
            var itemsSource = new DummyItemsSource();
#if !DEBUG
            new AuthorizingItemsSource(itemsSource)
#endif
            return itemsSource;
        }
    }
}