using ProjectSharp.BLL;
using ProjectSharp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectSharp
{
    public partial class Form1 : Form
    {
        public FileHandler FileHandler;
        PodcastList PodcastList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileHandler = new FileHandler();
            PodcastList = new PodcastList();
            InitiateList();
            
            UpdatePodFeed();

            var ListViewItem = new ListViewItem();
            string[] KategoriLista = new string[] { "Mystery", "Humor", "Documentury" };
            foreach (var x in KategoriLista)
            {
                LvCategory.Items.Add(x);
            }  
        }
        private void InitiateList()
        {
            FileHandler.GetFeed();
            foreach (var feed in FileHandler.SavedFeeds)
            {
                string Uri = FileHandler.DownloadUrlFeed(feed.url);
                XDocument Document = FileHandler.XmlDocumentOfFeed(Uri);
                PodcastList.PodList.Add(new Podcasts(Document, feed.url));
            }

        }
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            LvCategory.Items.Add(TbAddCategory.Text);
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in LvCategory.SelectedItems)
            {
                LvCategory.Items.Remove(selectedItem);
            }
        }
        private async Task UpdatePodList(string Url)
        {
            if (PodcastList.UrlExist(Url))
            {
                MessageBox.Show("Feed med denna url finns redan i listan.");
                return;
            }
            var Document = await FileHandler.UpdateFeedList(Url);
            PodcastList.PodList.Add(new Podcasts(Document, Url));
            FileHandler.SavedFeeds.Add(new RssUrl(Url));
            UpdatePodFeed();
        }
        private void UpdatePodFeed()
        {
            if (LvFeed.InvokeRequired)
            {
                LvFeed.Invoke((MethodInvoker)delegate {
                    LvFeed.Items.Clear();
                });
            }
            else
            {
                LvFeed.Items.Clear();                
            }
            foreach (var pod in PodcastList.PodList)
            {
                AddToPodFeed(pod);
            }
        }
        private void AddToPodFeed(Podcasts pod)
        {
            if (LvFeed.InvokeRequired)
            {
                LvFeed.Invoke((MethodInvoker)delegate
                {
                    LvFeed.Items.Add(pod.ToListViewItem());
                });
            }
            else
            {
                LvFeed.Items.Add(pod.ToListViewItem());
            }
        }


        private void BtnAddFeed_Click(object sender, EventArgs e)
        {
            string Url = TbUrl.Text;
            if(Validering.TryParseFeed(Url))
            {               
                Task.Run(() => UpdatePodList(Url));
            }
        }

        private void BtnRemoveFeed_Click(object sender, EventArgs e)
        {
            Podcasts pod = (Podcasts)LvFeed.SelectedItems[0].Tag;
            PodcastList.PodList.Remove(pod);
            RssUrl tempRssFeed = new RssUrl();
            foreach (var rssFeed in FileHandler.SavedFeeds)
            {
                if (pod.Url == rssFeed.url)
                {
                    tempRssFeed = rssFeed;
                }
            }
            FileHandler.SavedFeeds.Remove(tempRssFeed);
            UpdatePodFeed();
        }

        private void TbUrl_Enter(object sender, EventArgs e)
        {
            TbUrl.Clear();
        }

        private void LvFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvFeed.SelectedItems.Count == 1)
            {               
                Podcasts pod = (Podcasts)LvFeed.SelectedItems[0].Tag;
                LvEpisodes.Items.Clear();
                foreach (var Episode in pod.Episodes)
                {
                    LvEpisodes.Items.Add(Episode.ToListViewItem());
                }
            }         
        }

        private void LvEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvEpisodes.SelectedItems.Count == 1)
            {
                Episode episode = new Episode();
                episode = (Episode)LvEpisodes.SelectedItems[0].Tag;
                TbDescription.Clear();
                TbDescription.Text = episode.Description;
            }
        }
    }
}
