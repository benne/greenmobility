using System;

namespace BenneIO.GreenMobility.ApiClients
{
    public class ApiResponse
    {
        internal ApiResponse(ApiHttpResponse httpResponse)
        {
            HttpResponse = httpResponse ?? throw new ArgumentNullException(nameof(httpResponse));
        }

        public ApiHttpResponse HttpResponse { get; }
    }
}