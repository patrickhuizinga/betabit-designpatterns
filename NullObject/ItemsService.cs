namespace BetaBit.DesignPatterns
{
    public class ItemsService
    {
        public string GetItemsByClaim(string claimId)
        {
            // Authorize
            return "items found based on ClaimId";
        }

        public string GetItemsByClient(string clientId)
        {
            // Authorize
            return "items found based on ClientId";
        }
    }
}
