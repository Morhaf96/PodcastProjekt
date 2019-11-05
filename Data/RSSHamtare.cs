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
    public class RSSHamtare : IFetchable<Avsnitt>
    {

        public RSSHamtare()
        {

        }


        public Podcast HamtaPodcast(Uri hamtaUrl)
        {
            Podcast podcast = new Podcast();
            try
            {
                XmlReader xmlLasare = XmlReader.Create(hamtaUrl.ToString());
                SyndicationFeed feed = SyndicationFeed.Load(xmlLasare);
                xmlLasare.Close();
                return PodcastFranSyndicationFeed(feed);
            }
            catch (NullReferenceException)
            {
                return podcast;
            }

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

            foreach (var item in SyndicationItemList)
            {
                output.Add(AvsnittFranSyndicationFeedAvsnitt(item));
            }

            return output;
        }

        private Avsnitt AvsnittFranSyndicationFeedAvsnitt(SyndicationItem syndicationItem)
        {
            Avsnitt output = new Avsnitt();
            output.avsnittTitel = syndicationItem.Title.Text;
            output.Beskrivning = syndicationItem.Summary.Text;

            return output;
        }




    }
}
