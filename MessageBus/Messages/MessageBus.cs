using System.Collections.Generic;
using System.Linq;

namespace BetaBit.DesignPatterns
{
    public class MessageBus
    {
        private readonly List<object> _consumers = new List<object>();

        public void Subscribe<TMessage>(IMessageConsumer<TMessage> consumer)
        {
            _consumers.Add(consumer);
        }

        public void Publish<TMessage>(TMessage message)
        {
            foreach (var consumer in _consumers.OfType<IMessageConsumer<TMessage>>())
            {
                consumer.Consume(message);
            }
        }
    }
}
