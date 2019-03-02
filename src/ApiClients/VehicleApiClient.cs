using BenneIO.GreenMobility.Models;
using System;
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

        public async Task<ApiResponse<VehicleDetails>> GetVehicleAsync(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            
            return await DoApiRequestAsync<VehicleDetails>($"vehicles/{id}");
        }

        // TODO: Resolve return type
        public async Task<ApiResponse> PostJourneyAsync(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            
            return await DoApiRequestAsync($"vehicles/{id}/journey", HttpMethod.Post);
        }

        public async Task<ApiResponse<IEnumerable<UploadItem>>> GetJourneyReportsAsync(string vehicleId, string journeyId, ReportDetails reportDetails)
        {
            if (vehicleId == null)
                throw new ArgumentNullException(nameof(vehicleId));
            if (journeyId == null)
                throw new ArgumentNullException(nameof(journeyId));
            if (reportDetails == null)
                throw new ArgumentNullException(nameof(reportDetails));
            
            return await DoApiRequestAsync<IEnumerable<UploadItem>>($"vehicles/{vehicleId}/journeys/{journeyId}/reports", HttpMethod.Post, reportDetails);
        }
    }
}