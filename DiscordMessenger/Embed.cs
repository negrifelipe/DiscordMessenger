using System.Collections.Generic;

namespace DiscordMessenger
{
    public class Embed
    {
        public string title { get; set; }

        public string url { get; set; }

        public Author author { get; set; }
        
        public string description { get; set; }

        public List<Field> fields { get; set; }

        public string image { get; set; }

        public string thumbnail { get; set; }
        
        public Footer footer { get; set; }
        public int color { get; set; }
    }
}