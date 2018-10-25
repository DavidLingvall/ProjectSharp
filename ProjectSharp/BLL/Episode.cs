using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSharp.BLL
{
    class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PubDate { get; set; }
        
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new[] {
                Title,
                Description
            });
        }
    }
}
