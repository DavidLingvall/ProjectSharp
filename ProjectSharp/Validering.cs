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
        public static bool CheckStringComparison(string CbText, string CompText)
        {
            bool match = false;
            if (CbText == CompText)
            {
                MessageBox.Show("Välj en " + CompText);
                match = true;
            }
            return match;
        }
        public static bool CheckCategoryInput(string Category)
        {
            bool accept = true;
            if (Category == "")
            {
                accept = false;
                MessageBox.Show("Skriv in kategori");
            }
            return accept;
        }
        public static bool CheckCategories(string Category, List<Category> Categories)
        {
            bool found = false;
            foreach (var c in Categories)
            {
                if (c.Name == Category)
                {
                    found = true;
                    MessageBox.Show("Kategorin finns redan");
                }
            }
            return found;
        }

    }
}
