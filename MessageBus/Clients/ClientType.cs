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

        public abstract TResult Accept<TResult>(IClientTypeVisitor<TResult> visitor);

        public static ClientType Consumer { get; } = new ConsumerImpl();

        public sealed class ConsumerImpl : ClientType
        {
            internal ConsumerImpl()
            {
            }

            public override IEnumerable<ClaimId> GetExternalClaimIds(Client client)
            {
                return client.ClaimIds;
            }

            public override TResult Accept<TResult>(IClientTypeVisitor<TResult> visitor)
            {
                return visitor.Visit(this);
            }
        }

        public static ClientType Business { get; } = new BusinessImpl();

        public sealed class BusinessImpl : ClientType
        {
            internal BusinessImpl()
            {
            }

            public override IEnumerable<ClaimId> GetExternalClaimIds(Client client)
            {
                return client.ClaimIds.Where(ci => !ci.IsBusinessInternal);
            }

            public override TResult Accept<TResult>(IClientTypeVisitor<TResult> visitor)
            {
                return visitor.Visit(this);
            }
        }

        public static ClientType Enterprise { get; } = new EnterpriseImpl();

        public sealed class EnterpriseImpl : ClientType
        {
            internal EnterpriseImpl()
            {
            }

            public override IEnumerable<ClaimId> GetExternalClaimIds(Client client)
            {
                // whoops, have to ask analist about this one
                throw new System.NotImplementedException();
            }

            public override TResult Accept<TResult>(IClientTypeVisitor<TResult> visitor)
            {
                return visitor.Visit(this);
            }
        }
    }
}
