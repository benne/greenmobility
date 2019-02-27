namespace BenneIO.GreenMobility.Models
{
    public class DeviceSubscription
    {
        public DeviceSubscription(string deviceToken, string applicationName)
        {
            DeviceToken = deviceToken;
            ApplicationName = applicationName;
        }

        public string DeviceToken { get; }

        public string ApplicationName { get; }
    }
}