using Newtonsoft.Json;

namespace BenneIO.GreenMobility
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; private set; }
    }
}