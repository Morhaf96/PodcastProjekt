using PodcastProjekt.Data;
using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Logic
{
    public class PodcastHanterare
    {
        private List<Podcast> Podcasts = new List<Podcast>();
        
        public void LaggTillStream(Uri adress)
        {
            RSSHamtare rsshamtare = new RSSHamtare();
            Podcasts.Add(rsshamtare.HamtaPodcast(adress));
        }
        public List<Podcast> HamtaPodcasts()
        {
            return Podcasts;
        }
    }
}
