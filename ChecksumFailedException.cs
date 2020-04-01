using System;
using System.Runtime.Serialization;

namespace Pixeval.AutoUpdater
{
    public class ChecksumFailedException : Exception
    {
        public ChecksumFailedException() { }
        protected ChecksumFailedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public ChecksumFailedException(string message) : base(message) { }
        public ChecksumFailedException(string message, Exception innerException) : base(message, innerException) { }
    }
}