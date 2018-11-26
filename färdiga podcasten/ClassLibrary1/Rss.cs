using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;



namespace ClassLibrary1
{
    public class Rss : AbstractClass

    {
        public void fetchRSS(string url)
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            
        }



        internal XmlDocument fetchDocument(string url)
        {
            throw new NotImplementedException();
        }
    }
}

