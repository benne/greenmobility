using BenneIO.GreenMobility.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class VehicleApiClient : ApiClientBase
    {
        internal VehicleApiClient(string token) : base(token)
        {
        }

        // TODO: Resolve return type
        public async Task<ApiResponse<IEnumerable<VehicleModel>>> GetModelsAsync()
        {
            return await DoApiRequestAsync<IEnumerable<VehicleModel>>("models");
        }

        public async Task<ApiResponse<IEnumerable<VehicleOption>>> GetOptionsAsync()
        {
            return await DoApiRequestAsync<IEnumerable<VehicleOption>>("options");
        }

        public async Task<ApiResponse<VehicleDetails>> GetVehicle(string id)
        {
            return await DoApiRequestAsync<VehicleDetails>($"vehicles/{id}");
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> PostJourney(string id)
        {
            return await DoApiRequestAsync($"vehicles/{id}/journey", HttpMethod.Post);
        }

        public async Task<ApiResponse<IEnumerable<UploadItem>>> GetJourneyReports(string vehicleId, string journeyId, ReportDetails reportDetails)
        {
            return await DoApiRequestAsync<IEnumerable<UploadItem>>($"vehicles/{vehicleId}/journeys/{journeyId}/reports", HttpMethod.Post, reportDetails);
        }
    }
}