using Newtonsoft.Json;

namespace DiscordMessenger
{
    public class Image
    {
        [JsonProperty("url")]
        public string Url{ get; set; }

        [JsonProperty("proxy_url")]
        public string ProxyIcon { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }
}