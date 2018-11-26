using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    public class Podcast
    {

        public string Title { get; set; }
        public string Path { get; set; }

        public int UpdateInterval { get; set; }

        public List<Episode> Episodes { get; set; }
        public string RssUrl { get;  set; }

        public override string ToString()
        {
            return Title;
        }

    }
    
}
