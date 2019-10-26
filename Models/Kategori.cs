using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Models
{
    public class Kategori
    {
        public List<string> Namn; 

        public Kategori(string ettNamn)
        {
            laggTillKategori(ettNamn);
        }

        public Kategori() {

        }

        public void bytNamn(string gammaltNamn, string nyttNamn) {

            int i = Namn.IndexOf(gammaltNamn);
            Namn[i] = nyttNamn;
        }

        public void laggTillKategori(string ettNamn) {
            Namn.Add(ettNamn);
        }

        public void taBortKategori(string ettNamn) {
           
            try
            {
                int i = Namn.IndexOf(ettNamn);
                Namn.RemoveAt(i);
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
        }

        public string visaKategoriLista(List<string> kategoriListan) {
            string listanIString="";
            foreach (string k in kategoriListan) {
                listanIString += k + "\n";
            }

            if (listanIString.Equals("")) {
                listanIString = "Det finns inga kategorier att visa!";
            }
            return listanIString;
        }
            
     }
}


