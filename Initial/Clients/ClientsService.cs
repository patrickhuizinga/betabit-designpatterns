namespace BetaBit.DesignPatterns
{
    public sealed class ClientsService
    {
        public Client GetClient(string clientId)
        {
            // Authorize
            return new Client()
            {
                ClientId = clientId,
                Type = ClientType.Business,
                ClaimIds = { "123abc", "456def" }
            };
        }
    }
}
