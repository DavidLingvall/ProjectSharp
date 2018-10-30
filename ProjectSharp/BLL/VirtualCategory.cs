using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSharp.BLL
{
    public class VirtualCategory
    {
        public List<Category> CategoryList = new List<Category>();
        public virtual void OrderByName()
        {
            CategoryList.OrderBy(C => C.Name);
        }
    }
}
