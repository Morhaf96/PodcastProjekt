using PodcastProjekt.Exceptions;
using PodcastProjekt.Logic;
using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PodcastProjekt
{
    public partial class Form1 : Form
    {
        private PodcastHanterare podcastHanterare = new PodcastHanterare();
        private Avsnitt avsnitt;
        KategoriHanterare kategori = new KategoriHanterare();
        public bool IsEditing;

        public Form1()
        {
            PodcastHanterare.UppdateradePodcast += UpdatedFeed;
            
            InitializeComponent();

            lasInPersistens();

            PodcastHanterare.UppdateradePodcast += UpdatedFeed;

        }

        private void UpdatedFeed(Object sender, EventArgs e)
        {

            if (!IsEditing)
            {
                uppdateraPodcast();
            }


        }

        private void lasInPersistens()
        {
            PersistensHanterare pHanterare = new PersistensHanterare();
            PersistentFil fil = pHanterare.Las();

            foreach (Kategori k in fil.kategoriLista) {
                KategoriHanterare.laggTillKategori(k);
            }
            foreach (Podcast p in fil.podcastLista){
                p.initialiseraKategori();
                podcastHanterare.LaggTillPodcast(p);
            }


            uppdateraKategori();
            uppdateraPodcast();

        }

        private void uppdateraKategori()
        {
            cmbKat.Items.Clear();
            lvKat.Items.Clear();

            try
            {
                foreach (Kategori k in KategoriHanterare.getKategoriLista())
                {
                    cmbKat.Items.Add(k);
                    ListViewItem item = new ListViewItem();
                    item.Text = k.KategoriNamn;
                    item.Tag = k;
                    lvKat.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void uppdateraPodcast()
        {
            dgvPod.Rows.Clear();
            List<Podcast> podcastLista = podcastHanterare.GetPodcasts();
            foreach (var podcast in podcastLista)
            {
                int rad = dgvPod.Rows.Add();
                dgvPod.Rows[rad].Cells["clmNamn"].Value = podcast.Titel;
                dgvPod.Rows[rad].Cells["clmKategori"].Value = podcast.PodcastKategori.KategoriNamn;
                dgvPod.Rows[rad].Cells["clmUppdateringsfrekvens"].Value = podcast.UppdateringsFrekvens.ToString();
                dgvPod.Rows[rad].Cells["clmAvsnitt"].Value = podcast.AvsnittLista.Count;
                dgvPod.Rows[rad].Tag = podcast;
                Console.WriteLine(podcast + " Har lästs in");
            }
        }


        private void btnLaggTillKat_Click(object sender, EventArgs e)
        {
                try {
                string textAttLagga = tbKategori.Text.Trim();
                KategoriHanterare.laggTillKategori(textAttLagga);
                }
                catch (Exception exception){
                MessageBox.Show(exception.Message);
                }
                tbKategori.Text = "";
                cmbKat.Items.Clear();
                lvKat.Items.Clear();
                uppdateraKategori();
                
        }

        private void btnSparaKat_Click(object sender, EventArgs e){

            if (!tbKategori.Text.Equals("")) {
                string gammaltNamn = lvKat.SelectedItems.ToString();
                string nyttNamn = tbKategori.Text.ToString();
                tbKategori.Text = "";
                try
                {
                    int i = lvKat.SelectedIndices[0];
                    Kategori kategori = (Kategori)lvKat.Items[i].Tag;
                    KategoriHanterare.bytNamn(kategori, nyttNamn);
                }

                catch (ArgumentOutOfRangeException ex) {
                    MessageBox.Show("Du måste först välja en kategori från boxen ovan!");
                }

                uppdateraKategori();

            }

            else {
                MessageBox.Show("Du måste välja en kategori för att ändra namnet på den!");
            }
        }

        private void btnTaBortKat_Click(object sender, EventArgs e) {
            if (lvKat.SelectedItems[0] == null)  {
                return;
            }

            int i = lvKat.SelectedIndices[0];
            Kategori kategori = (Kategori)lvKat.Items[i].Tag;

            try {
                KategoriHanterare.taBortKategori(kategori);
            }

            catch (KategoriUpptagenException ex){
                MessageBox.Show("Kategorin är knuten till en eller flera podcasts och kan därför inte tas bort!");
                
            }
            
            uppdateraKategori();
            tbKategori.Text = "";
        }

        
        private void lvKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                String text = lvKat.SelectedItems[0].Text;
                tbKategori.Text = text;
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message + "\n" + ex.GetType());
            }
        }

        private void btnLaggTillPod_Click(object sender, EventArgs e) {

            try {
                if (tbUrl.Text.Trim().Equals(string.Empty)) {
                    throw new TextFaltArTomException();
                }
                string hamtadUrl = tbUrl.Text.Trim();
                Uri hamtadUri = new Uri(hamtadUrl);
                var valdKategori = (Kategori)cmbKat.SelectedItem;
                podcastHanterare.LaggTillStream(hamtadUri, valdKategori);
                tbUrl.Clear();

                //int uppdateringsFrekvens = 0;
                //string valdUppdatering = cmbUppdatering.SelectedItem.ToString();
                //switch (valdUppdatering)
                //{
                //    case "1 min":
                //        uppdateringsFrekvens = 60000;
                //        break;
                //    case "3 min":
                //        uppdateringsFrekvens = 180000;
                //        break;
                //    case "5 min":
                //        uppdateringsFrekvens = 300000;
                //        break;
                //    case "10 min":
                //        uppdateringsFrekvens = 600000;
                //        break;
                //    default:
                //        uppdateringsFrekvens = 0;
                //        return;



                //}

            }

            catch (Exception ex) {
                string felmeddelande = "";
                if (ex is ValideringsException) {
                    felmeddelande = ex.Message;
                }
                if (ex is TextFaltArTomException) {
                    felmeddelande = "URL fältet får inte vara tomt!";
                    tbUrl.Focus();
                }
                if (ex is UriFormatException){
                    felmeddelande = "Vänligen ange en giltig URL!";
                    tbUrl.Text = "";
                    tbUrl.Focus();
                }
                if (ex is XmlException){
                    felmeddelande = "XML Datan kunde inte läsas! Vänligen ange en giltig XML URL!";
                    tbUrl.Focus();
                }
                if (ex is ArgumentException)
                {
                    felmeddelande = "Du måste välja en kategori från komboboxen till den nya podcasten!";

                }

                MessageBox.Show(felmeddelande, "Fel uppstod!");
            }
            
            uppdateraPodcast();
            
        }

        

        
        private void dgvPod_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPod.SelectedRows.Count !=0)
            {
                Podcast podcast = (Podcast) dgvPod.SelectedRows[0].Tag;
                HamtaAvsnitt(podcast.AvsnittLista);
            }
        }

        private void HamtaAvsnitt(List<Avsnitt> avsnittLista)
        {
            lbAvsnitt.Items.Clear();

            if (avsnittLista != null){
                foreach (Avsnitt avsnitt in avsnittLista) {
                    lbAvsnitt.Items.Add(avsnitt);
                }
            }
        }
        
        private void lbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvsnitt.SelectedItems.Count == 0)
            {
                return;
            }
            if (lbAvsnitt.SelectedItems[0] != null)
            {
                var podcast = (Avsnitt)lbAvsnitt.SelectedItems[0];
                avsnitt = podcast;
                string titel = avsnitt.Titel;
                string beskrivning = avsnitt.Beskrivning;
                lblAvsnittTitel.Text = titel;
                wbBeskrivning.DocumentText = beskrivning;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PersistensHanterare ph = new PersistensHanterare();
            ph.Skriv(new PersistentFil(PodcastHanterare.HamtaPodcasts(), KategoriHanterare.getKategoriLista()));

        }
    }
}

