using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Category
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public List<Podcast> Podcasts { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
