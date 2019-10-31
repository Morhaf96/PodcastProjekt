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
        private string sparadeKategorier = @"sparadeKategorier";


        public KategoriHanterare()
        {
        
        }

        public static void laggTillKategori(Kategori kategori) {

            try
            {
                Validering.valideraKategori(kategori);
            }
            catch (ValideringsException ex)
            {
                throw ex;

            }

            kategoriLista.Add(kategori);
        }

        public static void laggTillKategori(string kategoriNamn)
        {
            Kategori kategori = new Kategori(kategoriNamn);

            try
            {
                laggTillKategori(kategori);
            }
            catch (ValideringsException ex)
            {
                throw ex;
            }
        }

        public static Kategori getKategori(string kategoriNamn) {
            foreach (Kategori k in kategoriLista) {
                if (k.KategoriNamn == kategoriNamn){
                    return k;
                }
            }
            Kategori nyKategori = new Kategori(kategoriNamn);
            laggTillKategori(nyKategori);
            return nyKategori;
        }

        public static List<Kategori> getKategoriLista()
        {

            var Query =
                    from kategori in kategoriLista
                    orderby kategori.KategoriNamn ascending
                    select kategori;

            List<Kategori> sorteradKategoriLista = new List<Kategori>();
            foreach (Kategori k in Query)
            {
                sorteradKategoriLista.Add(k);
            }
            return sorteradKategoriLista;
        }

        public static void taBortKategori(Kategori kategori) {
            var podcast = PodcastHanterare.HamtaPodcasts();
            foreach (var p in podcast)
            {
                if (p.PodcastKategori == kategori)
                {

                    throw new KategoriUpptagenException();

                }
            }
            kategoriLista.Remove(kategori);
        }

        //--------------------------------------------------------------------//
        //--------------------------------------------------------------------//
        //--------------------------------------------------------------------//
        //--------------------------------------------------------------------//



        public void bytNamn(string gammaltNamn, string nyttNamn) {
            try
            {
                int i = kategoriLista.IndexOf(gammaltNamn);
                kategoriLista[i] = nyttNamn;

                File.WriteAllText(sparadeKategorier, string.Empty);
                using (StreamWriter sw = File.AppendText(sparadeKategorier)){
                    foreach (var c in kategoriLista){
                        sw.WriteLine(c);
                    }
                }

            }

            catch (ArgumentOutOfRangeException e) {
                MessageBox.Show("Inga kategorier hittades för det angivna namnet!", "Fel inmatning");
            }

            catch (ArgumentNullException e) {

                MessageBox.Show("Du måste välja en kategori för att byta namnet på!", "Fel inmatning");

            }
        }

        public void laggTillKategori(string kategoriNamn) {
            kategoriLista.Add(kategoriNamn);
            using (StreamWriter sw = File.AppendText(sparadeKategorier)) {
                sw.WriteLine(kategoriNamn);
            }
        }

        public void taBortKategori(string kategoriNamn) {
           
            try
            {
                kategoriLista.Remove(kategoriNamn);
                File.WriteAllText(sparadeKategorier, string.Empty);

                using (StreamWriter sw = File.AppendText(sparadeKategorier)){
                    foreach (var kat in kategoriLista){
                        sw.WriteLine(kat);
                    }
                }
                
            }

            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }
            
        }

        public List<string> getKategoriLista() {
            kategoriLista.Clear();

            if (File.Exists(sparadeKategorier) == true)
            {
                using (StreamReader sr = new StreamReader(sparadeKategorier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        kategoriLista.Add(line);
                    }
                }
            }

            return kategoriLista;
        }
            
     }
}


