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
        FileHandler FileHandler = new FileHandler();
        PodcastList PodcastList = new PodcastList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ListViewItem = new ListViewItem();
            string[] KategoriLista = new string[] { "Mystery", "Humor", "Documentury" };
            foreach (var x in KategoriLista)
            {
                LvCategory.Items.Add(x);
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
            foreach (var item in PodcastList)
            {
                LvFeed.Items.Add(item.ToListViewItem());
            }
        }

        private void BtnAddFeed_Click(object sender, EventArgs e)
        {
            string Url = TbUrl.Text;
            string Uri = FileHandler.DownloadUrlFeed(Url);
            XDocument Document = FileHandler.XmlDocumentOfFeed(Uri);

            PodcastList.Add(new Podcasts(Document));
            UpdatePodFeed();          
        }
    }
}
