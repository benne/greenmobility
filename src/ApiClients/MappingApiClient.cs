using BenneIO.GreenMobility.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class MappingApiClient : ApiClientBase
    {
        internal MappingApiClient(string token) : base(token)
        {
        }

        // TODO: Resolve return type
        public async Task<ApiResponse<HomeZoneZone>> GetHomeZoneAsync(string id)
        {
            return await DoApiRequestAsync<HomeZoneZone>($"mapping/homezones/{id}");
        }

        // TODO: Resolve return type
        public async Task<ApiResponse<IEnumerable<HomeZone>>> GetHomeZonesAsync()
        {
            return await DoApiRequestAsync<IEnumerable<HomeZone>>("mapping/homezones");
        }

        // TODO: Resolve return type
        public async Task<ApiResponse<LayerContent>> GetLayerAsync(string id)
        {
            return await DoApiRequestAsync<LayerContent>($"mapping/layers/{id}");
        }

        // TODO: Resolve return type
        public async Task<ApiResponse<IEnumerable<Layer>>> GetLayersAsync()
        {
            return await DoApiRequestAsync<IEnumerable<Layer>>("mapping/layers");
        }
    }
}