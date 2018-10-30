using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;
using ProjectSharp.BLL;

namespace ProjectSharp
{
    public static class Validering
    {
        public static bool TryParseFeed(string url)
        {
            try
            {
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));

                foreach (SyndicationItem item in feed.Items)
                {
                    Debug.Print(item.Title.Text);
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ogiltig Rss feed", "Höredu Du!");
                return false;
            }
        }
        public static bool CheckForItem(string Category, PodcastList List)
        {
            bool found = false;
            foreach (var pod in List.PodList)
            {
                if(pod.Category == Category)
                {
                    found = true;
                }
            }
            return found;
        }

    }
}
