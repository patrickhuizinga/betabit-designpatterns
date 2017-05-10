using System;
using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public class AuthorizingItemsSource : IItemsSource
    {
        private readonly IItemsSource _implementation;

        public AuthorizingItemsSource(IItemsSource implementation)
        {
            _implementation = implementation;
        }

        public IEnumerable<string> GetItemsByClaim(ClaimId claimId)
        {
            // Authorize
            return _implementation.GetItemsByClaim(claimId);
        }
    }

    // todo replace with RealProxy implementation
}
