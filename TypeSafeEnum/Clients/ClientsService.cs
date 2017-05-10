namespace BetaBit.DesignPatterns
{
    public sealed class ClientsService
    {
        public Client GetClient(ClientId clientId)
        {
            // Authorize
            return new Client()
            {
                ClientId = clientId,
                Type = ClientType.Business,
                ClaimIds = { new ClaimId("123abc"), new ClaimId("456def") }
            };
        }
    }
}
