using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiscordMessenger
{
    [Serializable]
    public class DiscordMessage
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("tts")]
        public bool TTS { get; set; }

        [JsonProperty("embeds")]
        public List<Embed> Embeds { get; set; } = new List<Embed>();

        public DiscordMessage SetUsername(string username)
        {
            Username = username;
            return this;
        }

        public DiscordMessage SetAvatar(string avatar)
        {
            AvatarUrl = avatar;
            return this;
        }

        public DiscordMessage SetContent(string content)
        {
            Content = content;
            return this;
        }

        public DiscordMessage SetTTS(bool tts)
        {
            TTS = tts;
            return this;
        }

        public Embed AddEmbed()
        {
            var embed = new Embed(this);
            Embeds.Add(embed);
            return embed;
        }

        public void SendMessage(string url)
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.UploadString(url, JsonConvert.SerializeObject(this));
        }

        public Task SendMessageAsync(string url)
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.UploadStringAsync(new Uri(url), JsonConvert.SerializeObject(this));
            return Task.CompletedTask;
        }
    }
}