using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public abstract class ApiClientBase
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        private readonly string _bearerToken;

        internal ApiClientBase(string token)
        {
            _bearerToken = token;
        }

        internal async Task<ApiResponse> DoApiRequestAsync(string relativeUrl, HttpMethod httpMethod = null, object payload = null, Dictionary<string, string> headers = null)
        {
            return await DoApiRequestAsync<NoResult>(relativeUrl, httpMethod, payload);
        }

        internal async Task<ApiResponse<T>> DoApiRequestAsync<T>(string relativeUrl, HttpMethod httpMethod = null, object payload = null, Dictionary<string, string> headers = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = Constants.BaseUrl;
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

                using (HttpRequestMessage request = new HttpRequestMessage(httpMethod ?? HttpMethod.Get, $"api/v3/{relativeUrl}"))
                {
                    if (payload != null)
                    {
                        string payloadJson = JsonConvert.SerializeObject(payload, SerializerSettings);
                        request.Content = new StringContent(payloadJson, Encoding.UTF8, "application/json");
                    }

                    if (headers != null)
                    {
                        foreach (KeyValuePair<string, string> header in headers)
                        {
                            request.Headers.Add(header.Key, header.Value);
                        }
                    }

                    using (HttpResponseMessage response = await httpClient.SendAsync(request))
                    {
                        T result = default(T);
                        string content = await response.Content.ReadAsStringAsync();
                        if (response.IsSuccessStatusCode && typeof(T) != typeof(NoResult))
                        {
                            result = JsonConvert.DeserializeObject<T>(content, SerializerSettings);
                        }

                        return new ApiResponse<T>(
                            new ApiHttpResponse(response.StatusCode, response.ReasonPhrase, content),
                            result);
                    }
                }
            }
        }
    }
}