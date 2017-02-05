using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Framework.Messaging
{
    /// <summary>
    /// delegate
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public delegate MessageResponse MessageHandler(MessageData data);
    
    /// <summary>
    /// Defines the base methods for message broker
    /// </summary>
    public interface IMessageBroker
    {
        /// <summary>
        /// Send data to registered handler
        /// </summary>
        /// <param name="messageType">Name of the handler</param>
        /// <param name="data">the data that will be sent to the handler</param>
        /// <returns>the handlers response, be careful not to register to same for it will return the last handlers response</returns>
        MessageResponse SendData(string messageType, MessageData data);

        /// <summary>
        /// Send data to registered handler
        /// </summary>
        /// <param name="messageType">Name of the handler</param>
        /// <param name="data">the data that will be sent to the handler</param>
        /// <returns>the handlers response, be careful not to register to same for it will return the last handlers response</returns>
        MessageResponse SendData(string messageType, object data);

        /// <summary>
        /// Sends Empty MessageData to registered handlers.
        /// </summary>
        /// <param name="messageType">Name of handler to call.</param>
        /// <returns>The handler reponse, not if multiple handlers are registered, the last handlers data will be returned.</returns>
        MessageResponse SendData(string messageType);

        /// <summary>
        /// Sends Empty MessageData to registered handlers, and returns MessageReponse.IsValid
        /// </summary>
        /// <param name="data">Data to send to the handler.</param>
        /// <param name="messageType">Name of handler to call.</param>
        /// <returns>True if handler succeeded, if multiple handlers are registered, the last handlers data will be returned.</returns>
        bool Notify(string messageType, MessageData data);

        /// <summary>
        /// Sends Empty MessageData to registered handlers, and returns MessageReponse.IsValid
        /// </summary>
        /// <param name="data">Data to send to the handler, object param is wrapped into MessageData.</param>
        /// <param name="messageType">Name of handler to call.</param>
        /// <returns>True if handler succeeded, if multiple handlers are registered, the last handlers data will be returned.</returns>
        bool Notify(string messageType, object data);

        /// <summary>
        /// Sends Empty MessageData to registered handlers, and returns MessageReponse.IsValid
        /// </summary>
        /// <param name="messageType">Name of handler to call.</param>
        /// <returns>True if handler succeeded, if multiple handlers are registered, the last handlers data will be returned.</returns>
        bool Notify(string messageType);
    }
}
