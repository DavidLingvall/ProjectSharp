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
    }
}
