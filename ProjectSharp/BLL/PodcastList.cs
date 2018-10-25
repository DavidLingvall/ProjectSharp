using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSharp.BLL
{
    class PodcastList : List<Podcasts>
    {
        public void OrderByName()
        {
            this.OrderBy(P => P.Title);
        }
    }
}
