namespace BetaBit.DesignPatterns
{
    public sealed class ClientsClient
    {
        private readonly ClientsService _service;

        public ClientsClient(ClientsService service)
        {
            _service = service;
        }

        public Client GetClient(ClientId clientId)
        {
            // try return from cache

            int retries = 2;
            retry:
            try
            {
                var result = _service.GetClient(clientId);
                // cache result
                return result;
            }
            catch
            {
                if (retries-- > 0)
                    goto retry;

                throw;
            }
        }
    }
}
