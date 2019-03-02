using BenneIO.GreenMobility.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenneIO.GreenMobility.ApiClients
{
    public class DeviceApiClient : ApiClientBase
    {
        internal DeviceApiClient(string token) : base(token)
        {
        }

        public async Task<ApiResponse> DeleteDeviceNotificationAsync(DeviceSubscription subscription)
        {
            if (subscription == null)
                throw new ArgumentNullException(nameof(subscription));
            
            return await DoApiRequestAsync($"device/notification/{subscription.ApplicationName}/{subscription.DeviceToken}", HttpMethod.Delete);
        }

        public async Task<ApiResponse> PostDeviceNotificationAsync(DeviceSubscription subscription)
        {
            if (subscription == null)
                throw new ArgumentNullException(nameof(subscription));
            
            return await DoApiRequestAsync($"device/notification", HttpMethod.Post, subscription);
        }
    }
}