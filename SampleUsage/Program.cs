using System;
using System.Collections.Generic;
using DiscordMessenger;

namespace SampleUsage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            new DiscordMessage()
                .SetUsername("Test Message")
                .SetAvatar("https://i.imgur.com/xNGfbn3.png")
                .SetContent("A test discord message using the Discord Messenger Library")
                .AddEmbed()
                    .SetTimestamp(DateTime.Now)
                    .SetTitle("Test Embed")
                    .SetAuthor("Feli", "https://i.imgur.com/xNGfbn3.png", "https://i.imgur.com/xNGfbn3.png")
                    .SetDescription("You can use this library for everything you want")
                    .SetColor(14177041)
                    .AddField("Test Field", "Test Value")
                    .AddField("Test Field", "Test Value Inline", true)
                    .SetFooter("Test Footer", "https://i.imgur.com/xNGfbn3.png")
                .Build()
                .SendMessage("URL Here");
        }
    }
}