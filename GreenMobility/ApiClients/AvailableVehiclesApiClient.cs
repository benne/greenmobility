using BenneIO.GreenMobility.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class AvailableVehiclesApiClient : ApiClientBase
    {
        internal AvailableVehiclesApiClient(string token) : base(token)
        {
        }

        public async Task<ApiResponse<IEnumerable<LocatedVehicle>>> GetAvailableVehiclesAsync(int cityId, Position minPosition, Position maxPosition)
        {
            return await DoApiRequestAsync<IEnumerable<LocatedVehicle>>($"availableVehicles/{cityId}?minLat={minPosition.Lat}&maxLat={maxPosition.Lat}&minLon={minPosition.Lon}&maxLon={maxPosition.Lon}");
        }
    }
}