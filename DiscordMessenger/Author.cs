using Newtonsoft.Json;
using System;

namespace DiscordMessenger
{
    [Serializable]
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