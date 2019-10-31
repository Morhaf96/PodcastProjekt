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
        
        public static bool isEmptyTextBox(TextBox enTextBox) {
            bool isEmpty = false;
            if (enTextBox.Text.Trim().Equals("")) {
                isEmpty = true;
                MessageBox.Show("Detta textfält får inte vara tomt!");
                enTextBox.Focus();
            }
            return isEmpty;
        }

        public static void valideraComboBoxVald(ComboBox cmb)
        {

            if (cmb.SelectedItem == null)
            {
                throw new ValideringsException("Du måste välja ett element från ComboBoxen!");
            }
            return;

        }

        public static void valideraKategori(Kategori kategori)
        {
            if (kategori.KategoriNamn.Trim(' ') == string.Empty)
            {
                throw new ValideringsException("Du måste ange en kategori först!");
            }
            return;
        }

        public static void valideraPodcast(Podcast podcast)
        {

            if (podcast.Uri.ToString().Trim(' ') == string.Empty)
            {
                throw new ValideringsException("Podcast URL får inte vara tom!");
            }
            return;
        }
    }
    
}
