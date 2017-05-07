namespace BetaBit.DesignPatterns
{
    public sealed class ItemsClient
    {
        private readonly ItemsService _service;

        public ItemsClient(ItemsService service)
        {
            _service = service;
        }

        public string GetItemsByClaim(ClaimId claimId)
        {
            // try return from cache

            int retries = 2;
            retry:
            try
            {
                var result = _service.GetItemsByClaim(claimId);
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

        public string GetItemsByClient(ClientId clientId)
        {
            return _service.GetItemsByClient(clientId);
        }
    }
}
