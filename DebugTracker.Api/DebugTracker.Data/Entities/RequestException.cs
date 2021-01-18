using System;
using System.Runtime.Serialization;

namespace DebugTracker.Data.Entities
{
    [Serializable]
    public class RequestException : System.Exception
    {
        private string v;
        private string stackTrace;

        public RequestException()
        {
        }

        public RequestException(string message) : base(message)
        {
        }

        public RequestException(string v, string stackTrace)
        {
            this.v = v;
            this.stackTrace = stackTrace;
        }

        public RequestException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected RequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}