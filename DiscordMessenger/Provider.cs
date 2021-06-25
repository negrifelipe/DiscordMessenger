using Newtonsoft.Json;

namespace DiscordMessenger
{
    public class Provider
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}