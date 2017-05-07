namespace BetaBit.DesignPatterns
{
    public sealed class ClaimSearchContext : ISearchContext
    {
        public ClaimId ClaimId { get; }
        public string Title => $"Claim {ClaimId}";

        public ClaimSearchContext(ClaimId claimId)
        {
            ClaimId = claimId;
        }

        public void UpdateSearchPage(SearchPageViewModel searchPage)
        {
            searchPage.ClaimId = ClaimId;
        }
    }
}
