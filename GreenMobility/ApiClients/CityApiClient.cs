using BenneIO.GreenMobility.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class CityApiClient : ApiClientBase
    {
        internal CityApiClient(string token) : base(token)
        {
        }

        public async Task<ApiResponse<IEnumerable<City>>> GetCitiesAsync()
        {
            return await DoApiRequestAsync<IEnumerable<City>>("cities");
        }
    }
}