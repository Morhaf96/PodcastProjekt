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
        public List<string> KategoriLista { get; set; }


        public Kategori()
        {

        }

        public Kategori(string ettNamn)
        {
            KategoriLista.Add(ettNamn);
        }

        

        public void bytNamn(string gammaltNamn, string nyttNamn) {

            int i = KategoriLista.IndexOf(gammaltNamn);
            KategoriLista[i] = nyttNamn;
        }

        public void laggTillKategori(string ettNamn) {
            KategoriLista.Add(ettNamn);
        }

        public void taBortKategori(string ettNamn) {
           
            try
            {
                int i = KategoriLista.IndexOf(ettNamn);
                KategoriLista.RemoveAt(i);
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


