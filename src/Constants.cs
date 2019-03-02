using System;

namespace BenneIO.GreenMobility
{
    internal static class Constants
    {
        internal readonly static Uri BaseUrl = new Uri("https://gm-dkcph-api.vulog.com/identity");

        internal readonly static string AnonymousClientId = "Basic";

        internal readonly static Guid AnonymousClientSecret = Guid.Parse("8714a848-02f0-4962-a3fb-69c723b6989a");

        internal readonly static string AnonymousScope = "CarSharing";

        internal readonly static string AnonymousGrantType = "client_credentials";

        internal readonly static string UserClientId = "GM-DKCPH";

        internal readonly static Guid UserClientSecret = Guid.Parse("a1bc2274-4558-40d1-bbc5-730af483cbd1");

        internal readonly static string UserScope = "CarSharing offline_access openid";

        internal readonly static string UserGrantType = "password";
    }
}