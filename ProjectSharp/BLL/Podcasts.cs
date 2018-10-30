using ProjectSharp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectSharp.BLL
{
    public class Podcasts
    {
        public List<Episode> Episodes = new List<Episode>();
        public string Title { get; set; }
        public string Url { get; set; }
        public int EpisodeCount { get; set; } 
        public string Interval { get; set; }
        public string Category { get; set; }

        System.Timers.Timer aTimer;
        FileHandler fh = new FileHandler();

        public Podcasts(XDocument Document, string Url, string Interval, string Category)
        {
            AddEpisodes(Document);
            SetTitle(Document);
            this.Url = Url;
            this.Interval = Interval;
            this.Category = Category;
            Timer(GetInterval(Interval));
        }
        public Podcasts()
        {

        }

        public void OrderEpisodesByDate()
        {
            //this.OrderBy(E => )
        }

        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem( new[] {
                EpisodeCount.ToString(),
                Title,
                Interval,
                Category
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
        public int CountEpisodes(XDocument Document)
        {
            int Count = 0;
            foreach (var i in Document.Descendants("item"))
            {
                Count++;                
            }
            return Count;
        }

        private void Timer(int interval)
        {
            aTimer = new System.Timers.Timer(interval * 600);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
            var doc = await fh.GetFeedList(Url);
            Episodes.Clear();
            AddEpisodes(doc);
        }

        private int GetInterval(string interval)
        {
            if (interval == "5 minuter")
            {
                return 5;
            }
            else if (interval == "15 minuter")
            {
                return 15;
            }
            else if (interval == "30 minuter")
            {
                return 30;
            }
            else if (interval == "60 minuter")
            {
                return 60;
            }
            return 10000;
        }

    }
}
