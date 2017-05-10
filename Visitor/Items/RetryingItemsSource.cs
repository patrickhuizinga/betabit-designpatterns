using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public class RetryingItemsSource : IItemsSource
    {
        private readonly IItemsSource _implementation;
        private readonly int _retries;

        public RetryingItemsSource(IItemsSource implementation, int retries)
        {
            _implementation = implementation;
            _retries = retries;
        }

        public IEnumerable<string> GetItemsByClaim(ClaimId claimId)
        {
            int retries = _retries;
            retry:
            try
            {
                return _implementation.GetItemsByClaim(claimId);
            }
            catch
            {
                if (retries --> 0)
                    goto retry;

                throw;
            }
        }
    }
}