using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public class ItemsService
    {
        public IEnumerable<string> GetItemsByClaim(ClaimId claimId)
        {
            // Authorize
            return new[] { "items found based on ClaimId" };
        }
    }
}
