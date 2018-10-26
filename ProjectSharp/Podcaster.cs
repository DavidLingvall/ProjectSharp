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
                PodcastList.PodList.Add(new Podcasts(Document));
            }

        }

        private void LvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void UpdatePodFeed()
        {
            LvFeed.Items.Clear();
            foreach (var item in PodcastList.PodList)
            {
                LvFeed.Items.Add(item.ToListViewItem());
            }
        }

        private void BtnAddFeed_Click(object sender, EventArgs e)
        {
            string Url = TbUrl.Text;
            if(Validering.TryParseFeed(Url))
            {
                FileHandler.SavedFeeds.Add(new RssUrl(Url));
                //Task.Run(() => FileHandler.DownloadFeed(Url));
            }
        }
    }
}
