﻿using ProjectSharp.DAL;
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
    }
}
