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

        public async Task<ApiResponse> ChangePassword(Credential credential)
        {
            return await DoApiRequestAsync("changePassword", HttpMethod.Post, credential);
        }

        public async Task<ApiResponse> ResetLostPassword(CredentialWithToken credentialWithToken)
        {
            return await DoApiRequestAsync("resetLostPassword", HttpMethod.Post, credentialWithToken);
        }

        public async Task<ApiResponse> SendLostPasswordEmail(string email)
        {
            return await DoApiRequestAsync("sendLostPasswordEmail", HttpMethod.Post, email);
        }

        public async Task<ApiResponse<UserResult>> UpdateUser(UserData user)
        {
            return await DoApiRequestAsync<UserResult>("user", HttpMethod.Put, user);
        }

        public async Task<ApiResponse> PostPromocode(ApplyPromocode promocode)
        {
            return await DoApiRequestAsync("promocodes", HttpMethod.Post, promocode);
        }

        public async Task<ApiResponse> PostUserAgreement(int cityId)
        {
            return await DoApiRequestAsync("user/agreements", HttpMethod.Post, cityId);
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> GetCurrentJourney(bool includeKey, Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"user/currentJourney?includeKey={includeKey.ToString().ToLower()}", headers: headers);
        }

        public async Task<ApiResponse<LocatedVehicle>> GetCurrentJourneyVehicle(Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync<LocatedVehicle>("user/currentJourney/vehicle", headers: headers);
        }

        public async Task<ApiResponse<UserResult>> GetUser()
        {
            return await DoApiRequestAsync<UserResult>("user");
        }

        public async Task<ApiResponse<UserResult>> PostUser(UserRegistration registration)
        {
            return await DoApiRequestAsync<UserResult>("user", HttpMethod.Post, registration);
        }

        public async Task<ApiResponse<UserProfile>> GetUserProfile()
        {
            return await DoApiRequestAsync<UserProfile>("user/profile");
        }
    }
}