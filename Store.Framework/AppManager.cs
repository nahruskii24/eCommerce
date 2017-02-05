using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Framework.Messaging;
using System.Web;

namespace Store.Framework
{
    public static class AppManager
    {
        /// <summary>
        /// Register handlers
        /// </summary>
        /// <returns></returns>
        private static IMessageBroker MessagingConfig()
        {
            MessageBrokerBuilder msgBuilder =new MessageBrokerBuilder();
            //Register handlers
            //ex: msgBuilder.Register(Messages.DeligateDef,HandlerClass.HandlerName);

            return msgBuilder.Create();
        }

        // ***************************************************************************************
        // Do Not Change Below DONT even touch
        // ***************************************************************************************

        private static bool _isInitialized = false;
        private const string MsgBroker = "S_MSGBROKER";
        public static IMessageBroker Messaging => 
            (IMessageBroker) HttpContext.Current.Application[MsgBroker];

        /// <summary>
        /// if in italized skip other wise lock the state register 
        /// Messaging to it and finally unlock it.
        /// </summary>
        public static void Initialize(HttpApplicationState appState)
        {
            if (_isInitialized) return;
            appState.Lock();
            appState[MsgBroker] = MessagingConfig();

            _isInitialized = true;
            appState.UnLock();
        }
    }
}
