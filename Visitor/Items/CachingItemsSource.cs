using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public class CachingItemsSource : IItemsSource
    {
        private readonly IItemsSource _implementation;

        public CachingItemsSource(IItemsSource implementation)
        {
            _implementation = implementation;
        }

        public IEnumerable<string> GetItemsByClaim(ClaimId claimId)
        {
            var result = _implementation.GetItemsByClaim(claimId);
            // cache result
            return result;
        }
    }
}