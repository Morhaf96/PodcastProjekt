﻿using PodcastProjekt.Data;
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
        private RSSHamtare rssHamtare = new RSSHamtare();

        public delegate void UppdateradePodcastEventHandler(object sender, EventArgs e);
        public static event UppdateradePodcastEventHandler UppdateradePodcast;


        public void LaggTillPodcast(Podcast podcast)
        {
            podcast.StartaTimer();
            podcast.TimerTick += VidUppdateradPodcast;
            Podcasts.Add(podcast);


        }



        public void LaggTillStream(Uri adress, Kategori kategori, int uppdateringsFrekvens)
        {
            if (kategori == null)
            {
                throw new KategoriNullException();
            }
            else if (uppdateringsFrekvens == 0)
            {
                throw new ValideringsException();
            }
            try
            {
                Podcast podcast = new RSSHamtare().HamtaPodcast(adress);
                podcast.Uri = adress;
                podcast.PodcastKategori = kategori;
                podcast.UppdateringsFrekvens = uppdateringsFrekvens;
                LaggTillPodcast(podcast);
            }
            catch (ValideringsException ex)
            {
                throw ex;
            }

        }

        public void TaBortPodcast(Podcast podcast)
        {
            Podcasts.Remove(podcast);
        }

        public List<Podcast> GetPodcasts()
        {
            return Podcasts;
        }

        public static List<Podcast> HamtaPodcasts()
        {
            var sorteradLista = Podcasts
                                .OrderBy(item => item.Titel)
                                .ToList();

            return sorteradLista;
        }
        public static List<Podcast> HamtaPodcastsPaKategori(Kategori kategori)
        {
            List<Podcast> podcastLista = Podcasts.Where(item => item.PodcastKategori == kategori)
                               .ToList();
            return podcastLista;

        }


        public async static void UppdateraPodcastAvsnitt(Podcast podcast)
        {
            RSSHamtare hamtare = new RSSHamtare();
            Uri podcastUri = podcast.Uri;
            Podcast enPodcast = hamtare.HamtaPodcast(podcastUri);
            await Task.Run(() => { podcast.AvsnittLista = enPodcast.AvsnittLista; });
        }

        static void VidUppdateradPodcast(object sender, EventArgs e)
        {
            UppdateraPodcastAvsnitt((Podcast)sender);
            if (UppdateradePodcast != null)
            {
                UppdateradePodcast(typeof(PodcastHanterare), EventArgs.Empty);
            }

        }

        public static void SynkaKategori()
        {
            foreach (var podcasts in Podcasts)
            {
                podcasts.PodcastKategori = KategoriHanterare.GetKategori(podcasts.PodcastKategori.KategoriNamn);
            }
        }

        public RSSHamtare GetRssHamtare()
        {
            return rssHamtare;
        }
        public static void SparaListanTillFil(List<Podcast> poddar)
        {
            string filnamn = "PodcastLokalData.json";
            var jsonSkrivare = new JsonSkrivare(filnamn);
            jsonSkrivare.SparaPodcasts(poddar);
        }

        public void LasFranFil()
        {
            string filnamn = "PodcastLokalData.json";
            var jsonLasare = new JsonLasare(filnamn);
            var podcastLista = jsonLasare.LasPodcastLista();
            foreach (var podcast in podcastLista)
            {
                Podcasts.Add(podcast);
            }
        }

    }
}
