using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSharp.Interfaces
{
    interface IList
    {
        string Title { get; set; }
        ListViewItem ToListViewItem();
        
    }
}
