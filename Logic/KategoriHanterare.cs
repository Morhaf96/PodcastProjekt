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

        public static void laggTillKategori(Kategori kategori)
        {

            try
            {
                Validering.valideraKategoriAngivet(kategori);


            }
            catch (ValideringsException ex)
            {
                throw ex;

            }



            kategoriLista.Add(kategori);
        }

        public static void laggTillKategori(string kategoriNamn)
        {
            Kategori kategori = new Kategori(kategoriNamn.ToUpper());

            try
            {
                Validering.valideraKategoriFinns(kategoriLista, kategoriNamn);
                laggTillKategori(kategori);
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

        public static Kategori getKategori(string kategoriNamn)
        {
            foreach (Kategori k in kategoriLista)
            {
                if (k.KategoriNamn == kategoriNamn)
                {
                    return k;
                }
            }
            Kategori nyKategori = new Kategori(kategoriNamn);
            laggTillKategori(nyKategori);
            return nyKategori;
        }

        public static List<Kategori> getKategoriLista()
        {
            List<Kategori> sorteradKategoriLista = new List<Kategori>();
            foreach (Kategori k in kategoriLista)
            {
                sorteradKategoriLista.Add(k);
            }
            return sorteradKategoriLista;
            //
        }

        public static void taBortKategori(Kategori kategori)
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

        public static void bytNamn(Kategori kategori, string nyttNamn)
        {


            try
            {
                Validering.valideraKategoriFinns(kategoriLista, nyttNamn);
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


    }
}


