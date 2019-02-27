using BenneIO.GreenMobility.ApiClients;
using System;
using System.Runtime.Serialization;

namespace BenneIO.GreenMobility
{
    public class GreenMobilityLoginException : Exception
    {
        public GreenMobilityLoginException(string message, ApiHttpResponse response) : base(message)
        {
            HttpResponse = response ?? throw new ArgumentNullException(nameof(HttpResponse));
        }

        protected GreenMobilityLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ApiHttpResponse HttpResponse { get; }
    }
}