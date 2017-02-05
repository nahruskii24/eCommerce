using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Framework.Messaging
{
    /// <summary>
    /// defines the functions of the Message data
    /// </summary>
    public sealed class MessageData
    {
        private readonly Dictionary<Type, object> _data = new Dictionary<Type, object>();

        public static MessageData Empty => new MessageData();

        /// <summary>
        /// checks if objesct is type of T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns>true if object types match</returns>
        public static bool IsTypeof<T>(object obj)
        {
            return obj is T;
        }

        /// <summary>
        /// used by Contas to see if message data has type
        /// </summary>
        /// <param name="targetType"></param>
        /// <returns>true if data has specified type or if it can be assingn to the type or if it derives from it</returns>
        private bool HasType(Type targetType)
        {
            if (_data.ContainsKey(targetType))
            {
                return true;
            }
            return (from type in _data.Keys let o = _data[type] select type)
                .Any(type => targetType.IsAssignableFrom(type) || type.IsSubclassOf(targetType));
        }

        /// <summary>
        /// checks if Message data contains type
        /// </summary>
        /// <param name="targetTypes"></param>
        /// <returns></returns>
        public bool Contains(params Type[] targetTypes)
        {
            return targetTypes.Aggregate(true, (current, type) => current && HasType(type));
        }

        /// <summary>
        /// helper to retrieve data based on type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>data as T or a nullable type if it cannot convert it over</returns>
        public T Get<T>()
        {
            Type target = typeof(T);
            if (_data.ContainsKey(target))
            {
                return (T)_data[target];
            }
            foreach (Type type in _data.Keys)
            {
                object o = _data[type];
                if (o is T || type.IsAssignableFrom(target) || type.IsSubclassOf(target))
                {
                    return (T)o;
                }
            }
            return default(T);
        }

        /// <summary>
        /// addis item to message data as long as it has a value
        /// </summary>
        public void Push(object o)
        {
            if (o != null)
            {
                _data.Add(o.GetType(), o);
            }
        }



        /// <summary>
        /// takes the array of objects and pushes them to the message data 
        /// </summary>
        /// <param name="listObjects"></param>
        /// <returns> message data</returns>
        public static MessageData Create(params object[] listObjects)
        {
            MessageData data = new MessageData();

            foreach (object o in listObjects)
            {
                data.Push(o);
            }
            return data;
        }
    }
}
