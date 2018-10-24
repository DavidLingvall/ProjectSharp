using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSharp
{
    public partial class Form1 : Form
    {
        ListViewItem ListViewItem = new ListViewItem();
        CategoryList CategoryList = new CategoryList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListViewWithCategorys();
        }

        private void FillListViewWithCategorys()
        {
            CategoryList.AddCategoryToListTest();
            foreach (var category in CategoryList.Categorys)
            {

                LvCategory.Items.Add(category.Name);
            }
        } 

        private void LvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryList.AddCategoryToList(new Category(TbAddCategory.Text));
            LvCategory.Items.Add(TbAddCategory.Text);
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in LvCategory.SelectedItems)
            {
                LvCategory.Items.Remove(selectedItem);
            }
        }
    }
}
