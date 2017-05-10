namespace BetaBit.DesignPatterns
{
    public interface IClientTypeVisitor<TResult>
    {
        TResult Visit(ClientType.ConsumerImpl consumer);
        TResult Visit(ClientType.BusinessImpl business);
        TResult Visit(ClientType.EnterpriseImpl enterprise);
    }
}
