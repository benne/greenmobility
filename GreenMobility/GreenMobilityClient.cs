using BenneIO.GreenMobility.ApiClients;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility
{
    public class GreenMobilityClient
    {
        public readonly string BearerToken;

        public AvailableVehiclesApiClient AvailableVehiclesApi => new AvailableVehiclesApiClient(BearerToken);
        public CityApiClient CityApi => new CityApiClient(BearerToken);
        public DeviceApiClient DeviceApi => new DeviceApiClient(BearerToken);
        public JourneyApiClient JourneyApi => new JourneyApiClient(BearerToken);
        public MappingApiClient MappingApi => new MappingApiClient(BearerToken);
        public UserApiClient UserApi => new UserApiClient(BearerToken);
        public VehicleApiClient VehicleApi => new VehicleApiClient(BearerToken);

        private GreenMobilityClient(string token)
        {
            BearerToken = token;
        }

        public static async Task<GreenMobilityClient> LoginAsync()
        {
            ApiResponse<Token> token = await DoAnonymousLoginAsync();
            if (token.Result == null)
                throw new GreenMobilityLoginException($"Failed to get anonymous token: {token.HttpResponse.ReasonPhrase}", token.HttpResponse);

            return new GreenMobilityClient(token.Result.AccessToken);
        }

        public static async Task<GreenMobilityClient> LoginAsync(string userName, string password)
        {
            if (userName == null)
                throw new ArgumentNullException(nameof(userName));
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            ApiResponse<Token> token = await DoUserLoginAsync(userName, password);
            if (token.Result == null)
                throw new GreenMobilityLoginException($"Failed to get user token: {token.HttpResponse.ReasonPhrase}", token.HttpResponse);

            return new GreenMobilityClient(token.Result.AccessToken);
        }

        public static GreenMobilityClient LoginAsync(string token)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token));

            return new GreenMobilityClient(token);
        }

        private static async Task<ApiResponse<Token>> DoAnonymousLoginAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = Constants.BaseUrl;
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "identity/core/connect/token"))
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>
                    {
                        { "scope", Constants.AnonymousScope },
                        { "client_id", Constants.AnonymousClientId },
                        { "client_secret", Constants.AnonymousClientSecret.ToString() },
                        { "grant_type", Constants.AnonymousGrantType }
                    };

                    request.Content = new FormUrlEncodedContent(fields);
                    using (HttpResponseMessage response = await httpClient.SendAsync(request))
                    {
                        Token token = null;
                        string content = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            token = JsonConvert.DeserializeObject<Token>(content);
                        }

                        return new ApiResponse<Token>(
                            new ApiHttpResponse(response.StatusCode, response.ReasonPhrase, content),
                            token);
                    }
                }
            }
        }

        private static async Task<ApiResponse<Token>> DoUserLoginAsync(string userName, string password)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = Constants.BaseUrl;
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "identity/core/connect/token"))
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>
                    {
                        { "username", userName },
                        { "password", password },
                        { "scope", Constants.UserScope },
                        { "client_id", Constants.UserClientId },
                        { "client_secret", Constants.UserClientSecret.ToString() },
                        { "grant_type", Constants.UserGrantType }
                    };

                    request.Content = new FormUrlEncodedContent(fields);
                    using (HttpResponseMessage response = await httpClient.SendAsync(request))
                    {
                        Token token = null;
                        string content = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            token = JsonConvert.DeserializeObject<Token>(content);
                        }

                        return new ApiResponse<Token>(
                            new ApiHttpResponse(response.StatusCode, response.ReasonPhrase, content),
                            token);
                    }
                }
            }
        }
    }
}