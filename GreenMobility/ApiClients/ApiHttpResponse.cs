using System.Net;

namespace BenneIO.GreenMobility.ApiClients
{
    public class ApiHttpResponse
    {
        internal ApiHttpResponse(HttpStatusCode statusCode, string reasonPhrase, string content)
        {
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
            Content = content;
        }

        public HttpStatusCode StatusCode { get; }

        public string ReasonPhrase { get; }

        public string Content { get; }
    }
}