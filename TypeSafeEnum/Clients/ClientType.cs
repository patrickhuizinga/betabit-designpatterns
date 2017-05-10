using System.Collections.Generic;
using System.Linq;

namespace BetaBit.DesignPatterns
{
    public abstract class ClientType
    {
        private ClientType()
        {
        }

        public abstract IEnumerable<ClaimId> GetExternalClaimIds(Client client);

        public static ClientType Consumer { get; } = new ConsumerImpl();

        private sealed class ConsumerImpl : ClientType
        {
            public override IEnumerable<ClaimId> GetExternalClaimIds(Client client)
            {
                return client.ClaimIds;
            }
        }

        public static ClientType Business { get; } = new BusinessImpl();

        private sealed class BusinessImpl : ClientType
        {
            public override IEnumerable<ClaimId> GetExternalClaimIds(Client client)
            {
                return client.ClaimIds.Where(ci => !ci.IsBusinessInternal);
            }
        }

        public static ClientType Enterprise { get; } = new EnterpriseImpl();

        private sealed class EnterpriseImpl : ClientType
        {
            public override IEnumerable<ClaimId> GetExternalClaimIds(Client client)
            {
                // whoops, have to ask analist about this one
                throw new System.NotImplementedException();
            }
        }
    }
}
