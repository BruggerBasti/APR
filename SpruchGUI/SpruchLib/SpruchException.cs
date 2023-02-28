using System.Runtime.Serialization;

namespace SpruchLib
{
    [Serializable]
    public class SpruchException : Exception
    {
        public SpruchException()
        {
        }

        public SpruchException(string? message) : base(message)
        {
        }

        public SpruchException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SpruchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}