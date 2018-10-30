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
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ProjectSharp
{
    public partial class Form1 : Form
    {
        public Category Categories = new Category();
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
            Categories.ReadFileToList();
            UpdateListView();
            UpdateCategoryCombobox();

            FillInterval();
        }

        private void UpdateListView()
        {
            foreach (var Category in Categories.CategoryList)
            {
                if (Category.Name != null)
                {
                    LvCategory.Items.Add(Category.Name);
                }                  
            }
        }

        private void UpdateCategoryCombobox()
        {
            CbCategory.Items.Clear();
            foreach (var Category in Categories.CategoryList)
            {
                if (Category.Name != null)
                {
                    CbCategory.Items.Add(Category.Name);
                }
            }
        }
        private void InitiateList()
        {
            FileHandler.GetFeed();
            foreach (var feed in FileHandler.SavedFeeds)
            {
                string Uri = FileHandler.DownloadUrlFeed(feed.url);
                XDocument Document = FileHandler.XmlDocumentOfFeed(Uri);
                PodcastList.PodList.Add(new Podcasts(Document, feed.url, feed.Interval, feed.Category));
            }

        }
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            Categories.AddToList(new Category(TbAddCategory.Text));
            LvCategory.Items.Add(TbAddCategory.Text);
            UpdateCategoryCombobox();
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in LvCategory.SelectedItems)
            {
                string ChosenCategory = selectedItem.Text;
                Categories.RemoveFromList(ChosenCategory);
                LvCategory.Items.Remove(selectedItem);
                TbAddCategory.Clear();
                UpdateCategoryCombobox();
            }
        }
        private async Task UpdatePodList(string Url, string Category, string Interval)
        {
            if (PodcastList.UrlExist(Url))
            {
                MessageBox.Show("Feed med denna url finns redan i listan.");
                return;
            }
            var Document = await FileHandler.GetFeedList(Url);
            PodcastList.PodList.Add(new Podcasts(Document, Url,Interval,Category));
            FileHandler.SavedFeeds.Add(new RssUrl(Url, Interval, Category));
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
            string Interval = CbUpdateInterval.Text;
            string Category = CbCategory.Text;

            if(Validering.TryParseFeed(Url))
            {               
                Task.Run(() => UpdatePodList(Url, Category, Interval));
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
                EpisodesColumn.Text = pod.Title;
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
        private void FillInterval()
        {
            CbUpdateInterval.Items.Add("5 minuter");
            CbUpdateInterval.Items.Add("15 minuter");
            CbUpdateInterval.Items.Add("30 minuter");
            CbUpdateInterval.Items.Add("60 minuter");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (LvFeed.SelectedItems.Count == 1)
            {
                Podcasts pod = (Podcasts)LvFeed.SelectedItems[0].Tag;
                if (CbCategory.Text == "Kategori")
                {
                    MessageBox.Show("Ingen Kategori vald");
                }
                else
                {
                    pod.Interval = CbUpdateInterval.Text;
                }
                if (CbUpdateInterval.Text == "Frekvens")
                {
                    MessageBox.Show("Ingen frekvens vald");
                }
                else
                {
                    pod.Category = CbCategory.Text;
                }
                UpdatePodFeed();
            }
        }
    }
}
