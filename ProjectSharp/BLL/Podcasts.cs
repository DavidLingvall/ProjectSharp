using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectSharp.BLL
{
    class Podcasts
    {
        public List<Episode> Episodes = new List<Episode>();
        public string Title { get; set; }
        public string Url { get; set; }
        public int EpisodeCount { get; set; } 
        public Podcasts(XDocument Document, string Url)
        {
            AddEpisodes(Document);
            SetTitle(Document);
            this.Url = Url;
        }

        public void OrderEpisodesByDate()
        {
            //this.OrderBy(E => )
        }

        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem( new[] {
                EpisodeCount.ToString(),
                Title
            });

            item.Tag = this;
            return item;
        }

        private void SetTitle(XDocument Document)
        {
            Title = Document.Root.Element("channel").Element("title").Value;
        }
        private void AddEpisodes(XDocument Document)
        {          
            foreach (var i in Document.Descendants("item"))
            {
                EpisodeCount++;
                var pod = new Episode()
                {
                    Title = i.Element("title").Value,
                    Description = i.Element("description").Value,
                    PubDate = i.Element("pubDate").Value
                };
                Episodes.Add(pod);
            }
        }
        
    }
}
