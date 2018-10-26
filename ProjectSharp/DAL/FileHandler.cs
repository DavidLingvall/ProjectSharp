using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProjectSharp.DAL
{
    public class FileHandler
    {
        WebClient WebClient = new WebClient();
        public List<RssUrl> SavedFeeds = new List<RssUrl>();


        public FileHandler()
        {
            EncodeToUnicode();
        }
        void EncodeToUnicode()
        {
            WebClient.Encoding = Encoding.UTF8;
        }

        public string DownloadUrlFeed(string url)
        {
            string Uri = WebClient.DownloadString(url);
            return Uri;
        }

        public XDocument XmlDocumentOfFeed(string Uri)
        {
            XDocument Document = XDocument.Parse(Uri);
            return Document; 
        }

        public async Task<XDocument> UpdateFeedList(string url)
        {
            var XmlDocument = await Task.Run(() => XmlDocumentOfFeed(DownloadUrlFeed(url)));
            return XmlDocument;
        }

        public void SaveFeed()
        {

            using (Stream fs = new FileStream("RssFeed.xml",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<RssUrl>));
                serializer.Serialize(fs, SavedFeeds);
            }
        }
        public void GetFeed()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<RssUrl>));

            using (FileStream fs = File.OpenRead("RssFeed.xml"))
            {
                SavedFeeds = (List<RssUrl>)serializer.Deserialize(fs);
            }
        }
        
    }
}
