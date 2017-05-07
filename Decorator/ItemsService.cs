namespace BetaBit.DesignPatterns
{
    public class ItemsService
    {
        public string GetItemsByClaim(ClaimId claimId)
        {
            // Authorize
            return "items found based on ClaimId";
        }

        public string GetItemsByClient(ClientId clientId)
        {
            // Authorize
            return "items found based on ClientId";
        }
    }
}
