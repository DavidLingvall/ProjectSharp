using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectSharp.DAL
{
    class FileHandler
    {
        WebClient WebClient = new WebClient();
        
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
    }
}
