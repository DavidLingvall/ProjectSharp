using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSharp.DAL
{
    [Serializable]
    public class RssUrl : ISerializable
    {
        public string url { get; set; }
        public string Interval { get; set; }
        public string Category { get; set; }

        public RssUrl()
        {

        }
        public RssUrl(string url, string Interval, string Category)
        {
            this.url = url;
            this.Category = Category;
            this.Interval = Interval;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("url", url);
            info.AddValue("Interval", Interval);
            info.AddValue("Category", Category);
        }
        public RssUrl(SerializationInfo info, StreamingContext ctxt)
        {
            url = (string)info.GetValue("url", typeof(string));
            Interval = (string)info.GetValue("Interval", typeof(string));
            Category = (string)info.GetValue("Category", typeof(string));
        }
    }
}
