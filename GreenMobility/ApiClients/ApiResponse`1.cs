namespace BenneIO.GreenMobility.ApiClients
{
    public class ApiResponse<T> : ApiResponse
    {
        internal ApiResponse(ApiHttpResponse httpResponse, T result)
            : base(httpResponse)
        {
            Result = result;
        }

        public T Result { get; }
    }
}