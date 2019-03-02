using BenneIO.GreenMobility.ApiClients;
using IdentityModel.Client;
using System;
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
            ApiResponse<string> token = await DoAnonymousLoginAsync();
            if (token.Result == null)
                throw new GreenMobilityLoginException($"Failed to get anonymous token: {token.HttpResponse.ReasonPhrase}", token.HttpResponse);

            return new GreenMobilityClient(token.Result);
        }

        public static async Task<GreenMobilityClient> LoginAsync(string userName, string password)
        {
            if (userName == null)
                throw new ArgumentNullException(nameof(userName));
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            ApiResponse<string> token = await DoUserLoginAsync(userName, password);
            if (token.Result == null)
                throw new GreenMobilityLoginException($"Failed to get user token: {token.HttpResponse.ReasonPhrase}", token.HttpResponse);

            return new GreenMobilityClient(token.Result);
        }

        public static GreenMobilityClient LoginAsync(string token)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token));

            return new GreenMobilityClient(token);
        }

        private static async Task<ApiResponse<string>> DoAnonymousLoginAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                TokenResponse tokenResponse = await httpClient.RequestClientCredentialsTokenAsync(
                    new ClientCredentialsTokenRequest
                    {
                        Address = "https://gm-dkcph-api.vulog.com/identity/core/connect/token",
                        ClientId = "Basic",
                        ClientSecret = "8714a848-02f0-4962-a3fb-69c723b6989a",
                        Scope = "CarSharing"
                    });

                return new ApiResponse<string>(
                        new ApiHttpResponse(tokenResponse.HttpStatusCode, tokenResponse.HttpErrorReason, tokenResponse.Raw),
                        tokenResponse.AccessToken);
            }
        }

        private static async Task<ApiResponse<string>> DoUserLoginAsync(string userName, string password)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                TokenResponse tokenResponse = await httpClient.RequestPasswordTokenAsync(
                    new PasswordTokenRequest
                    {
                        Address = "https://gm-dkcph-api.vulog.com/identity/core/connect/token",
                        ClientId = "GM-DKCPH",
                        ClientSecret = "a1bc2274-4558-40d1-bbc5-730af483cbd1",
                        Scope = "CarSharing offline_access openid",
                        UserName = userName,
                        Password = password
                    });

                return new ApiResponse<string>(
                        new ApiHttpResponse(tokenResponse.HttpStatusCode, tokenResponse.HttpErrorReason, tokenResponse.Raw),
                        tokenResponse.AccessToken);
            }
        }
    }
}