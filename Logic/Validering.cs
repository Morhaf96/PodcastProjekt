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

        public static void IsEmptyTextBox(TextBox enTextBox)
        {

            if (enTextBox.Text.Trim().Equals(string.Empty))
            {
                throw new TextFaltArTomException();
            }

        }

        public static void ValideraKategoriAngivet(Kategori kategori)
        {
            if (kategori.KategoriNamn.Trim() == string.Empty)
            {
                throw new ValideringsException("Du måste ange namn på kategori först!");
            }

            return;
        }

        public static void ValideraKategoriFinns(List<Kategori> kategoriLista, string kategoriNamn)
        {

            foreach (Kategori k in kategoriLista)
            {
                if (k.KategoriNamn.ToUpper() == kategoriNamn.ToUpper())
                {
                    throw new KategoriFinnsRedanException("Det finns redan en kategori med det angivna namnet!");
                }
                return;

            }
        }

    }

}
