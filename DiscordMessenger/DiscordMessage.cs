using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiscordMessenger
{
    public class DiscordMessage
    {
        public string username { get; set; }

        public string avatar_url { get; set; }
        
        public string content { get; set; }

        public List<Embed> embeds { get; set; }
        
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