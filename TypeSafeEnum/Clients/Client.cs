using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public sealed class Client
    {
        public ClientId ClientId { get; set; }
        public ClientType Type { get; set; }
        public List<ClaimId> ClaimIds { get; } = new List<ClaimId>();
    }
}
