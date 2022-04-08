using System;
using System.Runtime.Serialization;

namespace CustomList
{
    [Serializable]
    internal class EmptyBookException : Exception
    {
        public EmptyBookException()
        {
        }

        public EmptyBookException(string message) : base(message)
        {
        }

        public EmptyBookException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyBookException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}