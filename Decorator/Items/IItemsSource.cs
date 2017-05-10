using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public interface IItemsSource
    {
        IEnumerable<string> GetItemsByClaim(ClaimId claimId);
    }
}