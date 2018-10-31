using ProjectSharp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectSharp.BLL
{
    public class PodcastList
    {
        public List<Podcasts> PodList = new List<Podcasts>();

        public void OrderByName()
        {
             
        }
        public bool UrlExist(string url)
        {
            bool Found = false;

            if (PodList == null)
            {
                Found = false;
            }
            else
            {
                foreach (var pod in PodList)
                {
                    if (pod.Url == url)
                    {
                        Found = true;
                    }
                }
            }         
            return Found;
        }
        public int GetEpisodeCount(string url)
        {         
            foreach (var pod in PodList)
            {
                if (pod.Url == url)
                {
                    return pod.EpisodeCount;
                }
            }
            return 0;
        }

        public Podcasts GetPodcast(string url)
        {
            foreach (var pod in PodList)
            {
                if (pod.Url == url)
                {
                    return pod;
                }
            }
            return null;
        }
    }
}
