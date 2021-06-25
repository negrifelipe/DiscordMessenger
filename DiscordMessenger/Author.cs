using Newtonsoft.Json;

namespace DiscordMessenger
{
    public class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string Icon { get; set; }

        [JsonProperty("proxy_icon_url")]
        public string ProxyIcon { get; set; }
    }
}