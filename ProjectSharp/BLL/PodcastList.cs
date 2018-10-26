using ProjectSharp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectSharp.BLL
{
    class PodcastList
    {
        public List<Podcasts> PodList = new List<Podcasts>();

        public void OrderByName()
        {
            PodList.OrderBy(P => P.Title);
        }
    }
}
