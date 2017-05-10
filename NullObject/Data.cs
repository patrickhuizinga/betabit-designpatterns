using System.Collections.Generic;

namespace BetaBit.DesignPatterns
{
    public sealed class Data
    {
        public ISearchContext SearchContext { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}
