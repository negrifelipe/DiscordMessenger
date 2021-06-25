using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DiscordMessenger
{
    public class Embed
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("footer")]
        public Footer Footer { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("provider")]
        public Provider Provider { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; } = new List<Field>();

        [JsonIgnore]
        private DiscordMessage MessageInstance { get; set; }

        public Embed(DiscordMessage messageInstance)
        {
            MessageInstance = messageInstance;
        }

        public Embed SetTitle(string title)
        {
            Title = title;
            return this;
        }
        public Embed SetDescription(string description)
        {
            Description = description;
            return this;
        }
        public Embed SetUrl(string url)
        {
            Url = url;
            return this;
        }
        public Embed SetTimestamp(DateTime time)
        {
            Timestamp = time.ToString("yyyy-MM-ddTHH:mm:ssZ");
            return this;
        }
        public Embed SetColor(int color)
        {
            Color = color;
            return this;
        }
        public Embed SetFooter(string text, string icon = null, string proxyIcon = null)
        {
            Footer = new Footer() { Text = text, Icon = icon, ProxyIcon = proxyIcon };
            return this;
        }
        public Embed SetImage(string url, string height = null, string width = null, string proxyIcon = null)
        {
            Image = new Image() { Url = url, Height = height, Width = width, ProxyIcon = proxyIcon };
            return this;
        }
        public Embed SetThumbnail(string url, string height = null, string width = null, string proxyIcon = null)
        {
            Thumbnail = new Thumbnail() { Url = url, Height = height, Width = width, ProxyIcon = proxyIcon };
            return this;
        }
        public Embed SetVideo(string url, string height = null, string width = null, string proxyVideo = null)
        {
            Video = new Video { Url = url, Height = height, Width = width, ProxyVideo = proxyVideo };
            return this;
        }
        public Embed SetProvider(string name, string url = null)
        {
            Provider = new Provider() { Name = name, Url = url };
            return this;
        }
        public Embed SetAuthor(string name, string url = null, string icon = null, string proxyIcon = null)
        {
            Author = new Author() { Name = name, Icon = icon, ProxyIcon = proxyIcon, Url = url };
            return this;
        }
        public Embed AddField(string key, string value, bool inline = false)
        {
            Fields.Add(new Field()
            {
                Key = key,
                Value = value,
                Inline = inline
            });
            return this;
        }

        public DiscordMessage Build()
        {
            return MessageInstance;
        }
    }
}
