using System;

namespace BetaBit.DesignPatterns
{
    public class ItemsClient
    {
        private readonly ItemsService _service;

        public ItemsClient(ItemsService service)
        {
            _service = service;
        }

        public string GetItemsByClaim(string claimId)
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

        public string GetItemsByClient(string clientId)
        {
            return _service.GetItemsByClient(clientId);
        }
    }
}
