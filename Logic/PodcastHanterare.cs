using PodcastProjekt.Data;
using PodcastProjekt.Exceptions;
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
        private static List<Podcast> Podcasts = new List<Podcast>();
        
        public delegate void UppdateradePodcastEventHandler(object sender, EventArgs e);
        public static event UppdateradePodcastEventHandler UppdateradePodcast;


        public static List<Podcast> HamtaPodcasts()
        {
            var sorteradLista = Podcasts
                                .OrderBy(item => item.Titel)
                                .ToList();

            return sorteradLista;
        }
        public static List<Podcast> HamtaPodcasts(Kategori kategori)
        {
            var podcastLista = Podcasts.Where(item => item.PodcastKategori == kategori)
                               .ToList();
            return podcastLista;

        }


        public static void LaggTillPodcast(Podcast podcast)
        {
            try
            {
                Validering.valideraPodcast(podcast);
            }
            catch (ValideringsException ex)
            {
                throw ex;
            }

            podcast.startaTimer();
            podcast.TimerTick += vidUppdateradPodcast;
            Podcasts.Add(podcast);

        }

        

        public void LaggTillStream(Uri adress, Kategori kategori)
        {
            if (kategori == null)
            {
                throw new ArgumentException();
            }
            try
            {
                Podcast podcast = new RSSHamtare().HamtaPodcast(adress);
                podcast.PodcastKategori = kategori;
                LaggTillPodcast(podcast);
            }
            catch (ValideringsException ex)
            {
                throw ex;
            }
            
        }

        public static void taBortPodcast(Podcast podcast)
        {
            Podcasts.Remove(podcast);
        }


        public async static void uppdateraPodcastAvsnitt(Podcast podcast) {
            RSSHamtare hamtare = new RSSHamtare();
            Podcast enPodcast = hamtare.HamtaPodcast(podcast.Uri);
            await Task.Run(() => { podcast.AvsnittLista = enPodcast.AvsnittLista; });

        }

        static void vidUppdateradPodcast(object sender, EventArgs e)
        {
            uppdateraPodcastAvsnitt((Podcast)sender);
            if (UppdateradePodcast != null) {
                UppdateradePodcast(typeof(PodcastHanterare), EventArgs.Empty);
            }

        }

    }
}
