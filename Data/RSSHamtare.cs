using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PodcastProjekt.Data
{
    public class RSSHamtare: IFetchable
    {  
        public Podcast HamtaPodcast(Uri hamtaUrl)
        {
            XmlReader Lasare = XmlReader.Create(hamtaUrl.ToString());
            SyndicationFeed feed = SyndicationFeed.Load(Lasare);
            Lasare.Close();

            return PodcastFranSyndicationFeed(feed);


        }

        private Podcast PodcastFranSyndicationFeed(SyndicationFeed feed)
        {
            Podcast podcast = new Podcast();
            podcast.Titel = feed.Title.Text;

            podcast.AvsnittLista = AvsnittFranSyndicationFeedAllaAvsnitt(feed.Items);
            return podcast;
        }

        private List<Avsnitt> AvsnittFranSyndicationFeedAllaAvsnitt(IEnumerable<SyndicationItem> SyndicationItemList)
        {
            List<Avsnitt> output = new List<Avsnitt>();

            foreach(var item in SyndicationItemList)
            {
                output.Add(AvsnittFranSyndicationFeedAvsnitt(item));
            }
            return output;
        }

        private Avsnitt AvsnittFranSyndicationFeedAvsnitt(SyndicationItem syndicationItem) 
        {
            Avsnitt output = new Avsnitt();
            output.Titel = syndicationItem.Title.Text;
            output.Beskrivning = syndicationItem.Summary.Text;
            return output;
        }
    }
}
