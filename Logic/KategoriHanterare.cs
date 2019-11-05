using PodcastProjekt.Data;
using PodcastProjekt.Exceptions;
using PodcastProjekt.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastProjekt.Models
{
    public class KategoriHanterare
    {
        private static List<Kategori> kategoriLista = new List<Kategori>();

        public static void LaggTillKategori(Kategori kategori)
        {

            try
            {
                Validering.ValideraKategoriAngivet(kategori);


            }
            catch (ValideringsException ex)
            {
                throw ex;

            }



            kategoriLista.Add(kategori);
        }

        public static void LaggTillKategori(string kategoriNamn)
        {
            Kategori kategori = new Kategori(kategoriNamn.ToUpper());

            try
            {
                Validering.ValideraKategoriFinns(kategoriLista, kategoriNamn);
                LaggTillKategori(kategori);

            }
            catch (ValideringsException ex)
            {
                throw ex;
            }

            catch (KategoriFinnsRedanException ex)
            {
                throw ex;
            }

        }

        public static Kategori GetKategori(string kategoriNamn)
        {
            foreach (Kategori k in kategoriLista)
            {
                if (k.KategoriNamn == kategoriNamn)
                {
                    return k;
                }
            }
            Kategori nyKategori = new Kategori(kategoriNamn);
            LaggTillKategori(nyKategori);
            return nyKategori;
        }

        public static List<Kategori> GetKategoriLista()
        {
            List<Kategori> sorteradKategoriLista = new List<Kategori>();
            foreach (Kategori k in kategoriLista)
            {
                sorteradKategoriLista.Add(k);
            }
            return sorteradKategoriLista;

        }

        public static void TaBortKategori(Kategori kategori)
        {
            List<Podcast> podcast = PodcastHanterare.HamtaPodcasts();
            foreach (var p in podcast)
            {

                if (p.PodcastKategori == kategori)
                {

                    throw new KategoriUpptagenException();

                }
            }

            kategoriLista.Remove(kategori);

        }

        public static void BytNamn(Kategori kategori, string nyttNamn)
        {


            try
            {
                Validering.ValideraKategoriFinns(kategoriLista, nyttNamn);
                int i = kategoriLista.IndexOf(kategori);
                kategoriLista[i].KategoriNamn = nyttNamn.ToUpper();

            }

            catch (KategoriFinnsRedanException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                Console.WriteLine("BytNamn metoden i kategorihanterare " + ex.Message);
            }


        }
        public static void SparaListanTillFil(List<Kategori> kategorier)
        {
            string filnamn = "KategoriLokalData.json";
            var jsonSkrivare = new JsonSkrivare(filnamn);
            jsonSkrivare.SparaKategorier(kategorier);
        }

        public void LasFranFil()
        {
            string filnamn = "KategoriLokalData.json";
            var jsonLasare = new JsonLasare(filnamn);
            var kategorilista = jsonLasare.LasKategoriLista();
            kategoriLista.AddRange(kategorilista);
        }




    }
}


