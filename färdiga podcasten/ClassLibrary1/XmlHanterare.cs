using ClassLibrary1.Entities;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Serialization;

namespace Data
{
    public class XmlHanterare
    {
        
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Podcast));
        public void Save(Podcast podcast)
        {
            using (var writer = new StreamWriter(podcast.Path))
            {
                xmlSerializer.Serialize(writer, podcast);
            }
        }

        public void AddNew(string namn, string path, string category, string interval, string rssUrl)
        {
            AddNew(namn, path, category, int.Parse(interval), rssUrl);
        }

        public void AddNew(string namn, string path, string category, int interval, string rssUrl)
        {
            var podcast = new Podcast
            {
                Title = namn,
                Path = path,
                RssUrl = rssUrl,
                UpdateInterval = interval,
                Episodes = ReadRssFromUrl(rssUrl)
            };
            Save(podcast);
           
            
            
        }


        

        public List<Category> GetAllCategories()
        {
            var path = Directory.GetCurrentDirectory();
            var folders = Directory.GetDirectories(path);
            List<Category> categories = new List<Category>();
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                categories.Add(new Category() { Title = info.Name, Path = folder, Podcasts = GetAllPodcastsInCategory(folder) });
            }
            return categories;
        }






        private List<Podcast> GetAllPodcastsInCategory(string categoryPath)
        {
            var files = Directory.GetFiles(categoryPath);
            List<Podcast> podcasts = new List<Podcast>();
            foreach (var file in files)
            {
                var info = new FileInfo(file);

                using (var reader = new StreamReader(file))
                {
                    podcasts.Add((Podcast)xmlSerializer.Deserialize(reader));
                }
                
            }
            return podcasts;
        }

       
        
        private List<Episode> ReadRssFromUrl(string podcastPath)
        {
            var episodes = new List<Episode>();
            var reader = XmlReader.Create(podcastPath);
            var feed = SyndicationFeed.Load(reader);
            foreach (var item in feed.Items)
            {
                var episode = new Episode();
                episode.Title = item.Title.Text;
                //Hämta ut sökvägen till mp3-filen
                episode.Url = item.Links[1].Uri.OriginalString;

                episodes.Add(episode);
            }
            return episodes;
        }



       

    }
}