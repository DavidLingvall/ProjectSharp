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
        public Category Categories = new Category();
        FileHandler FileHandler = new FileHandler();
        PodcastList PodcastList = new PodcastList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ListViewItem = new ListViewItem();
            Categories.ReadFileToList();
            UpdateListView();
            UpdateCategoryCombobox();

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

        private void LvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void TbAddCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
