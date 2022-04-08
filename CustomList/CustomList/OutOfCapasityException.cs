using System;
using System.Runtime.Serialization;

namespace CustomList
{
    [Serializable]
    internal class OutOfCapasityException : Exception
    {
        public OutOfCapasityException()
        {
        }

        public OutOfCapasityException(string message) : base(message)
        {
        }

        public OutOfCapasityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfCapasityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}