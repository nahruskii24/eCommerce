using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Framework.Messaging
{
    internal class MessageBroker : IMessageBroker
    {
        private readonly ImmutableDictionary<string, MessageHandler> _handler;

        public MessageBroker(ImmutableDictionary<string, MessageHandler>.Builder builder)
        {
            _handler = builder.ToImmutable();
        }

        public MessageResponse SendData(string messageType, MessageData data)
        {
            return _handler.ContainsKey(messageType) ?
                _handler[messageType](data) : MessageResponse.Failed;
        }

        public MessageResponse SendData(string messageType, object data)
        {
            return SendData(messageType, MessageData.Create(data));
        }

        public MessageResponse SendData(string messageType)
        {
            return SendData(messageType, MessageData.Empty);
        }

        public bool Notify(string messageType, MessageData data)
        {
            return _handler.ContainsKey(messageType) && _handler[messageType](data).IsValid;
        }

        public bool Notify(string messageType, object data)
        {
            return Notify(messageType, MessageData.Create(data));
        }

        public bool Notify(string messageType)
        {
            return Notify(messageType, MessageData.Empty);
        }
    }
}
