using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public sealed class Client
    {
        public string ClientId { get; set; }
        public ClientType Type { get; set; }
        public List<string> ClaimIds { get; } = new List<string>();
    }
}
