using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Data
{
    public class AddNewPod
    {
        public static List<string> nyLista = new List<string>();
        public static List<String> kategoriLista = new List<String>();
        public List<String> hamtaLista()
        {
            return nyLista;
        }
        public List<String> hamtaKategori()
        {
            return kategoriLista;
        }
        public void laggTillNy(string namn, string url, string category, string interval)
        {
            Rss metod = new Rss();
            XmlDocument doc = metod.fetchDocument(url);
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + @".xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            int i = 0;

            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("channel");
            xmlOut.WriteElementString("interval", interval);
            xmlOut.WriteElementString("url", url);
            xmlOut.WriteElementString("lastSync", DateTime.Now.ToString());
            foreach (XmlNode item
               in doc.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                var description = item.SelectSingleNode("description");
                var enclosure = item.SelectSingleNode("enclosure/@url");

                xmlOut.WriteStartElement("item");

                xmlOut.WriteAttributeString("ID", "pod" + i);

                if (description.InnerText.Equals(""))
                {
                    xmlOut.WriteElementString("description", "Unfortunately, no description is available.");
                }
                else
                {
                    xmlOut.WriteElementString("description", description.InnerText);
                }

                xmlOut.WriteElementString("title", title.InnerText);
                xmlOut.WriteElementString("enclosure", enclosure.InnerText);
                xmlOut.WriteElementString("status", "Unlistened");

                xmlOut.WriteEndElement();
                i++;
            }

            xmlOut.WriteEndDocument();
            xmlOut.Close();
        }
    }
}