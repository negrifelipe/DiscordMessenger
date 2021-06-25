using Newtonsoft.Json;
using System;

namespace DiscordMessenger
{
    [Serializable]
    public class Footer
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon_url")]
        public string Icon { get; set; }

        [JsonProperty("proxy_icon_url")]
        public string ProxyIcon { get; set; }
    }
}
