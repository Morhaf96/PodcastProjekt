using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Models
{
    public class Avsnitt
    {
        public string Titel { get; set; }
        public string Beskrivning { get; set; }

        public Avsnitt() { 
        
        }

        public Avsnitt(string titel){
            this.Titel = titel;
        }

        public Avsnitt(string titel, string beskrivning){
            this.Titel = titel;
            this.Beskrivning = beskrivning;
        }

        public string getBeskrivning(Avsnitt avsnitt) {
            return Beskrivning;
        }

        public override string ToString(){
            return Titel;
        }

    }
    
}

//Värdelös försök till att koda sparaPodcast som det ska vara
//private void btnSparaPodcast_Click(object sender, DataGridViewCellEventArgs e)
//{
//    try
//    {
//        var rad = dgvPod.Rows[e.RowIndex];
//        var valdPodcast = (Podcast)rad.Tag;
//        var nyURI = new Uri(tbUrl.Text.Trim());
//        var rssHamtare = podcastHanterare.getRssHamtare();
//        var podcast = rssHamtare.HamtaPodcast(nyURI);

//        var nyKategori = (Kategori)cmbKat.SelectedItem;
//        string valdUppdatering = cmbUppdatering.SelectedItem.ToString();
//        int nyUppdategingsfrekvens = konverteraUppdateringsTextTillVarde(valdUppdatering);

//        valdPodcast.Titel = podcast.Titel;
//        valdPodcast.PodcastKategori = nyKategori;
//        valdPodcast.UppdateringsFrekvens = nyUppdategingsfrekvens;
//    }

//    catch (Exception ex)
//    {
//        string felmeddelande = "";
//        if (ex is ValideringsException)
//        {
//            felmeddelande = ex.Message;
//        }
//        if (ex is TextFaltArTomException)
//        {
//            felmeddelande = "URL fältet får inte vara tomt!";
//            tbUrl.Focus();
//        }
//        if (ex is UriFormatException)
//        {
//            felmeddelande = "Vänligen ange en giltig URL!";
//            tbUrl.Text = "";
//            tbUrl.Focus();
//        }
//        if (ex is XmlException)
//        {
//            felmeddelande = "XML Datan kunde inte läsas! Vänligen ange en giltig XML URL!";
//            tbUrl.Focus();
//        }
//        if (ex is ArgumentException)
//        {
//            felmeddelande = "Du måste välja en ny kategori från komboboxen till den nya podcasten!";

//        }


//        MessageBox.Show(felmeddelande, "Fel uppstod!");
//    }
//    uppdateraPodcast();
//}