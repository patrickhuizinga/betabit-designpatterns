namespace BetaBit.DesignPatterns
{
    public sealed class ClaimSearchContext : ISearchContext
    {
        public string ClaimId { get; }
        public string Title => $"Claim {ClaimId}";

        public ClaimSearchContext(string claimId)
        {
            ClaimId = claimId;
        }

        public void UpdateSearchPage(SearchPageViewModel searchPage)
        {
            searchPage.ClaimId = ClaimId;
        }
    }
}
