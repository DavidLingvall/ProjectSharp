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
        public string urlId { get; set; }

        public RssUrl()
        {

        }
        public RssUrl(string url)
        {
            this.url = url;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("urlId", urlId);
            info.AddValue("url", url);
        }
        public RssUrl(SerializationInfo info, StreamingContext ctxt)
        {
            urlId = (string)info.GetValue("urlId", typeof(string));
            url = (string)info.GetValue("url", typeof(string));
        }
    }
}
