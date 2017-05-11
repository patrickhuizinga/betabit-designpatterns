namespace BetaBit.DesignPatterns.Controllers
{
    public class ClientController
    {
        public bool CanShowTelephoneNumber(ClientType clientType)
        {
            return clientType.Accept(new CanTelephoneVisitor());
        }

        private sealed class CanTelephoneVisitor : IClientTypeVisitor<bool>
        {
            public bool Visit(ClientType.ConsumerImpl consumer) => false;
            public bool Visit(ClientType.BusinessImpl business) => true;
            public bool Visit(ClientType.EnterpriseImpl enterprise) => true;
        }
    }
}
