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

        public Form1()
        {
            InitializeComponent();
            
            uppdateraKategori();


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaggTillKat_Click(object sender, EventArgs e)
        {
                try {
                string textAttLagga = tbKategori.Text.Trim();
                KategoriHanterare.laggTillKategori(textAttLagga);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
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
                int i = lvKat.SelectedIndices[0];
                Kategori kategori = (Kategori)lvKat.Items[i].Tag;
                KategoriHanterare.bytNamn(kategori, nyttNamn);
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

        private void uppdateraKategori() {
            cmbKat.Items.Clear();
            lvKat.Items.Clear();
            
            foreach (var item in KategoriHanterare.getKategoriLista())
            {
                cmbKat.Items.Add(item);
            }

            try
            {
                foreach (Kategori k in KategoriHanterare.getKategoriLista())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = k.KategoriNamn;
                    item.Tag = k;
                    lvKat.Items.Add(item);
                    cmbKat.Items.Add(item);
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
            foreach (var podcast in podcastHanterare.GetPodcasts())
            {
                Console.WriteLine(podcast);
                int rad = dgvPod.Rows.Add();
                dgvPod.Rows[rad].Cells["clmNamn"].Value = podcast.Titel;
                if (podcast.PodcastKategori != null)
                {
                    dgvPod.Rows[rad].Cells["clmKategori"].Value = podcast.PodcastKategori.KategoriNamn;
                }
                dgvPod.Rows[rad].Cells["clmUppdateringsfrekvens"].Value = podcast.UppdateringsFrekvens;
                dgvPod.Rows[rad].Cells["clmAvsnitt"].Value = podcast.AvsnittLista.Count;
                dgvPod.Rows[rad].Tag = podcast;
            }
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
                string hamtadUrl = tbUrl.Text.Trim();
                Uri hamtadUri = new Uri(hamtadUrl);
                Kategori valdKategori = ((Kategori)cmbKat.SelectedItem);
                podcastHanterare.LaggTillStream(hamtadUri, valdKategori);

                int uppdateringsFrekvens = 0;
                string valdUppdatering = cmbUppdatering.SelectedItem.ToString();
                switch (valdUppdatering)
                {
                    case "1 min":
                        uppdateringsFrekvens = 60000;
                        break;
                    case "3 min":
                        uppdateringsFrekvens = 180000;
                        break;
                    case "5 min":
                        uppdateringsFrekvens = 300000;
                        break;
                    case "10 min":
                        uppdateringsFrekvens = 600000;
                        break;
                    default:
                        uppdateringsFrekvens = 0;
                        return;



                }

            }

            catch (Exception ex) {
                string felmeddelande = "";
                if (ex is ValideringsException){
                    felmeddelande = ex.Message;
                }
                if (ex is UriFormatException){
                    felmeddelande = "Vänligen ange en giltig URL!";
                    tbUrl.Focus();
                }
                if (ex is XmlException){
                    felmeddelande = "XML Datan kunde inte läsas! Vänligen ange en XML URL!";
                    tbUrl.Focus();
                }
                if (ex is KategoriNullException)
                {
                    felmeddelande = "Du måste välja en kategori från komboboxen till den nya podcasten!";

                }

                else {
                    felmeddelande = ex.Message;
                }
                var result = MessageBox.Show(felmeddelande);
            }
            uppdateraPodcast();
            tbUrl.Clear();
        }

        private void dgvPod_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPod_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPod.SelectedRows.Count != 0)
            {
                var podcast = (Podcast)dgvPod.SelectedRows[0].Tag;
                fyllPodcastLista(podcast.AvsnittLista);
            }
        }

        public void fyllPodcastLista(List<Avsnitt> AvsnittsLista)
        {
            lbAvsnitt.Items.Clear();
            if (AvsnittsLista != null)
            {
                foreach (var avsnitt in AvsnittsLista)
                {
                    lbAvsnitt.Items.Add(avsnitt);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }
    }

