using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Framework.Messaging
{
    public class MessageBrokerBuilder
    {
        private readonly ImmutableDictionary<string, MessageHandler>.Builder _builder;

        public MessageBrokerBuilder()
        {
            _builder = ImmutableDictionary.CreateBuilder<string, MessageHandler>();
        }

        /// <summary>
        /// registers handler 
        /// </summary>
        public void Register(string messageType,MessageHandler handler)
        {
            if (_builder.ContainsKey(messageType))
            {
                _builder[messageType] += handler;
            }
            else
            {
                _builder[messageType] = handler;
            }
        }

        /// <summary>
        /// After all handlers are registered Create The message broker
        /// </summary>
        /// <returns></returns>
        public IMessageBroker Create()
        {
            return new MessageBroker(_builder);
        }


    }
}
