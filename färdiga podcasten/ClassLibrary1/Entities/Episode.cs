using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Episode
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsPlayed { get; set; }
        public override string ToString()
        {
            return IsPlayed + Title;
        }
    }
}
