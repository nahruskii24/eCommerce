using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Framework.Messaging
{
    /// <summary>
    /// message response class
    /// </summary>
    public sealed class MessageResponse
    {
        private readonly object _payload;

        public bool IsValid { get; set; }

        /// <summary>
        /// Failed status response
        /// </summary>
        public static MessageResponse Success => new MessageResponse(new object());

        /// <summary>
        /// Sucess status response
        /// </summary>
        public static MessageResponse Failed => new MessageResponse(new object(), false);

        public MessageResponse(object payload, bool isValid = true)
        {
            _payload = payload;
            IsValid = isValid;
        }

        /// <summary>
        /// holds the reponse info based on expected type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>pay load data</returns>
        public T Payload<T>()
        {
            if (_payload == null)
            {
                return default(T);
            }

            Type type = _payload.GetType();
            Type target = typeof(T);
            if (_payload is T || target.IsAssignableFrom(type) || type.IsSubclassOf(target))
            {
                return (T) _payload;
            }
            return default(T);
        }
    }
}
