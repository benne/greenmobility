using BenneIO.GreenMobility.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class JourneyApiClient : ApiClientBase
    {
        internal JourneyApiClient(string token) : base(token)
        {
        }

        public async Task<ApiResponse> DeleteBookingAsync(string id)
        {
            return await DoApiRequestAsync($"journeys/{id}/booking", HttpMethod.Delete);
        }

        public async Task<ApiResponse> DeletePauseAsync(string id, Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"journeys/{id}/pause", HttpMethod.Delete, headers: headers);
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> PostPauseAsync(string id, Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"journeys/{id}/pause", HttpMethod.Post, headers: headers);
        }

        public async Task<ApiResponse> DeleteTripAsync(string id)
        {
            return await DoApiRequestAsync($"journeys/{id}/trip", HttpMethod.Delete);
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> PostTripAsync(string id, Position userPosition, TripDetails details)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"journeys/{id}/trip", HttpMethod.Post, details, headers);
        }

        public async Task<ApiResponse<TripDetails>> CreateTripInformationAsync(string id, TripDetails details)
        {
            return await DoApiRequestAsync<TripDetails>($"journeys/{id}/tripinformation", HttpMethod.Post, details);
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> DeleteLockAsync(string journeyId, Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"journeys/{journeyId}/trip", HttpMethod.Delete, headers: headers);
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> PostLockAsync(string id, Position userPosition)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                { "user-lat", userPosition.Lat.ToString() },
                { "user-lon", userPosition.Lon.ToString() }
            };
            return await DoApiRequestAsync($"journeys/{id}/trip", HttpMethod.Post, headers: headers);
        }
    }
}