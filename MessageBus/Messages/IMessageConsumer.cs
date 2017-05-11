namespace BetaBit.DesignPatterns
{
    public interface IMessageConsumer<in TMessage>
    {
        void Consume(TMessage message);
    }
}
