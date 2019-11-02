using PodcastProjekt.Exceptions;
using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastProjekt.Logic
{
    public static class Validering 
    {
        
        public static void isEmptyTextBox(TextBox enTextBox) {
           
            if (enTextBox.Text.Trim().Equals(string.Empty)) {
                throw new TextFaltArTomException();
            }
           
        }

        public static void valideraComboBoxVald(ComboBox cmb)   {

            if (cmb.SelectedItem == null) {
                throw new ValideringsException("Du måste välja ett element från ComboBoxen!");
            }
            return;

        }

        public static void valideraKategoriAngivet(Kategori kategori) {
            if (kategori.KategoriNamn.Trim() == string.Empty) {
                throw new ValideringsException("Du måste ange namn på kategori först!");
            }

            return;
        }

        public static void valideraKategoriFinns(List<Kategori> kategoriLista, Kategori nyKategori){
            
            foreach (Kategori k in kategoriLista)
            {
                if (k.KategoriNamn == nyKategori.KategoriNamn)
                {
                    throw new KategoriFinnsRedanException("Det finns redan en kategori med det angivna namnet!");
                }
                return;

            }
        }

        public static void valideraPodcast(Podcast podcast) {

            if (podcast.Uri.ToString().Trim() == string.Empty) {
                throw new ValideringsException("Podcast URL får inte vara tom!");
            }
            return;
        }
    }
    
}
