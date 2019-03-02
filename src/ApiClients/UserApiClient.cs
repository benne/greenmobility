using BenneIO.GreenMobility.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class UserApiClient : ApiClientBase
    {
        internal UserApiClient(string token) : base(token)
        {
        }

        public async Task<ApiResponse> ChangePasswordAsync(Credential credential)
        {
            return await DoApiRequestAsync("changePassword", HttpMethod.Post, credential);
        }

        public async Task<ApiResponse> ResetLostPasswordAsync(CredentialWithToken credentialWithToken)
        {
            return await DoApiRequestAsync("resetLostPassword", HttpMethod.Post, credentialWithToken);
        }

        public async Task<ApiResponse> SendLostPasswordEmailAsync(string email)
        {
            return await DoApiRequestAsync("sendLostPasswordEmail", HttpMethod.Post, email);
        }

        public async Task<ApiResponse<UserResult>> UpdateUserAsync(UserData user)
        {
            return await DoApiRequestAsync<UserResult>("user", HttpMethod.Put, user);
        }

        public async Task<ApiResponse> PostPromocodeAsync(ApplyPromocode promocode)
        {
            return await DoApiRequestAsync("promocodes", HttpMethod.Post, promocode);
        }

        public async Task<ApiResponse> PostUserAgreementAsync(int cityId)
        {
            return await DoApiRequestAsync("user/agreements", HttpMethod.Post, cityId);
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> GetCurrentJourneyAsync(bool includeKey, Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"user/currentJourney?includeKey={includeKey.ToString().ToLower()}", headers: headers);
        }

        public async Task<ApiResponse<LocatedVehicle>> GetCurrentJourneyVehicleAsync(Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync<LocatedVehicle>("user/currentJourney/vehicle", headers: headers);
        }

        public async Task<ApiResponse<UserResult>> GetUserAsync()
        {
            return await DoApiRequestAsync<UserResult>("user");
        }

        public async Task<ApiResponse<UserResult>> PostUserAsync(UserRegistration registration)
        {
            return await DoApiRequestAsync<UserResult>("user", HttpMethod.Post, registration);
        }

        public async Task<ApiResponse<UserProfile>> GetUserProfileAsync()
        {
            return await DoApiRequestAsync<UserProfile>("user/profile");
        }
    }
}