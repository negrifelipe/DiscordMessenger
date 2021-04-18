using System.Collections.Generic;
using DiscordMessenger;

namespace SampleUsage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            new DiscordMessage()
            {
                username = "Test Message",
                avatar_url = "https://i.imgur.com/xNGfbn3.png",
                content = "A test discord message using the Discord Messenger Library",
                embeds = new List<Embed>()
                {
                    new Embed()
                    {
                        title = "Test Embed",
                        author = new Author()
                        {
                            name = "Feli",
                            icon_url = "https://i.imgur.com/xNGfbn3.png",
                            url = "https://i.imgur.com/xNGfbn3.png"
                        },
                        description = "You can use this library for everything you want",
                        color = 14177041,
                        fields = new List<Field>()
                        {
                            new Field()
                            {
                                name = "Test Field",
                                value = "You can put values"
                            },
                            new Field()
                            {
                                name = "Test Field 2",
                                value = "You can put values"
                            },
                            new Field()
                            {
                                name = "Test Field 3",
                                value = "You can put values"
                            },
                            new Field()
                            {
                                name = "Inline Test",
                                value = "You can make them inline",
                                inline = true
                            },
                            new Field()
                            {
                                name = "Inline Test 2",
                                value = "You can make them inline",
                                inline = true
                            }
                        },
                        footer = new Footer()
                        {
                            text = "Test footer"
                        }
                    }
                }
            }.SendMessage("Url Here");
        }
    }
}