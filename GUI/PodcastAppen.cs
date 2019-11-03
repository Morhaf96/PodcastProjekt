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
        private bool harAndrats = false;


        public Form1()
        {
            PodcastHanterare.UppdateradePodcast += UpdatedFeed;

            InitializeComponent();

            lasInPersistens();

            PodcastHanterare.UppdateradePodcast += UpdatedFeed;

        }

        private void UpdatedFeed(Object sender, EventArgs e)
        {
            if (!harAndrats)
            {
                uppdateraPodcast();
            }
        }

        private void lasInPersistens()
        {
            PersistensHanterare pHanterare = new PersistensHanterare();
            PersistentFil fil = pHanterare.Las();

            foreach (Kategori k in fil.kategoriLista)
            {
                KategoriHanterare.laggTillKategori(k);
            }
            foreach (Podcast p in fil.podcastLista)
            {
                podcastHanterare.LaggTillPodcast(p);
                p.initialiseraKategori();
            }


            uppdateraKategori();
            uppdateraPodcast();

        }

        private void uppdateraKategori()
        {
            cmbKat.Items.Clear();
            lvKat.Items.Clear();
            ((DataGridViewComboBoxColumn)dgvPod.Columns["clmKategori"]).Items.Clear();

            try
            {
                foreach (Kategori k in KategoriHanterare.getKategoriLista())
                {
                    cmbKat.Items.Add(k);
                    ((DataGridViewComboBoxColumn)dgvPod.Columns["clmKategori"]).Items.Add(k);
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

            try
            {
                foreach (var podcast in podcastLista)
                {

                    int rad = dgvPod.Rows.Add();
                    dgvPod.Rows[rad].Cells["clmNamn"].Value = podcast.Titel;
                    dgvPod.Rows[rad].Cells["clmKategori"].Value = podcast.PodcastKategori;
                    string uppdateringsFrekvensString = konverteraUppdateringsVardeTillText(podcast.UppdateringsFrekvens);
                    dgvPod.Rows[rad].Cells["clmUppdateringsfrekvens"].Value = uppdateringsFrekvensString;
                    dgvPod.Rows[rad].Cells["clmAvsnitt"].Value = podcast.AvsnittLista.Count;
                    dgvPod.Rows[rad].Tag = podcast;
                }
            }
            catch (NullReferenceException)
            {
                return;
            }

        }

        private void uppdateraPodcastPerKategori(Kategori kategori)
        {
            dgvPod.Rows.Clear();
            List<Podcast> podcastLista = PodcastHanterare.HamtaPodcastsPaKategori(kategori);
            foreach (var podcast in podcastLista)
            {
                int rad = dgvPod.Rows.Add();
                dgvPod.Rows[rad].Cells["clmNamn"].Value = podcast.Titel;
                dgvPod.Rows[rad].Cells["clmKategori"].Value = podcast.PodcastKategori.KategoriNamn;
                string uppdateringsFrekvensString = konverteraUppdateringsVardeTillText(podcast.UppdateringsFrekvens);
                dgvPod.Rows[rad].Cells["clmUppdateringsfrekvens"].Value = uppdateringsFrekvensString;
                dgvPod.Rows[rad].Cells["clmAvsnitt"].Value = podcast.AvsnittLista.Count;
                dgvPod.Rows[rad].Tag = podcast;
            }
        }

        private void btnLaggTillKat_Click(object sender, EventArgs e)
        {
            try
            {
                string textAttLagga = tbKategori.Text.Trim().ToUpper();
                KategoriHanterare.laggTillKategori(textAttLagga);
            }

            catch (KategoriFinnsRedanException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (ValideringsException ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbKategori.Text = "";
            cmbKat.Items.Clear();
            lvKat.Items.Clear();
            uppdateraKategori();

        }

        private void btnSparaKat_Click(object sender, EventArgs e)
        {

            if (!tbKategori.Text.Equals(""))
            {
                string gammaltNamn = lvKat.SelectedItems.ToString();
                string nyttNamn = tbKategori.Text.ToString().ToUpper();

                List<Kategori> kategoriLista = KategoriHanterare.getKategoriLista();

                tbKategori.Text = "";
                try
                {

                    Validering.valideraKategoriFinns(kategoriLista, nyttNamn);
                    int i = lvKat.SelectedIndices[0];
                    Kategori kategori = (Kategori)lvKat.Items[i].Tag;
                    KategoriHanterare.bytNamn(kategori, nyttNamn);
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                catch (KategoriFinnsRedanException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                uppdateraKategori();

            }

            else
            {
                MessageBox.Show("Du måste välja en kategori och sen ange ett nytt namn i textrutan!");
            }
        }

        private void btnTaBortKat_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvKat.SelectedItems[0] == null)
                {
                    return;
                }
                int i = lvKat.SelectedIndices[0];
                Kategori kategori = (Kategori)lvKat.Items[i].Tag;
                KategoriHanterare.taBortKategori(kategori);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Ingen kategori är vald för att ta bort!");
            }

            catch (KategoriUpptagenException ex)
            {
                MessageBox.Show("Kategorin är knuten till en eller flera podcasts och kan därför inte tas bort!");

            }

            uppdateraKategori();
            tbKategori.Text = "";
        }

        private void btnLaggTillPod_Click(object sender, EventArgs e)
        {

            try
            {
                Validering.isEmptyTextBox(tbUrl);
                string hamtadUrl = tbUrl.Text.Trim();
                Uri hamtadUri = new Uri(hamtadUrl);
                var valdKategori = (Kategori)cmbKat.SelectedItem;
                string valdUppdatering = cmbUppdatering.SelectedItem.ToString();
                int uppdateringsFrekvens = konverteraUppdateringsTextTillVarde(valdUppdatering);

                podcastHanterare.LaggTillStream(hamtadUri, valdKategori, uppdateringsFrekvens);

                tbUrl.Clear();
                cmbKat.SelectedIndex = -1;
                cmbUppdatering.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                string felmeddelande = "";
                if (ex is KategoriNullException)
                {
                    felmeddelande = "Välj en kategori till den nya podcasten!";
                }

                if (ex is ValideringsException)
                {
                    felmeddelande = "Du måste välja en uppdateringsfrekvens från komboboxen";
                }
                if (ex is TextFaltArTomException)
                {
                    felmeddelande = "URL fältet får inte vara tomt!";
                    tbUrl.Focus();
                }
                if (ex is UriFormatException)
                {
                    felmeddelande = "Vänligen ange en giltig URL!";
                    tbUrl.Text = "";
                    tbUrl.Focus();
                }
                if (ex is XmlException)
                {
                    felmeddelande = "XMLException har fångats!";
                    tbUrl.Focus();
                }
                if (ex is NullReferenceException)
                {
                    felmeddelande = "Välj ett uppdateringsintervall till den nya podcasten!";

                }

                if (ex is System.Net.WebException)
                {
                    felmeddelande = "XML Datan kunde inte läsas från den angivna adressen!" + "\n \n" + "Vänligen ange en giltig XML URL!";
                }

                MessageBox.Show(felmeddelande, "Fel uppstod!");
            }

            uppdateraPodcast();

        }




        private void dgvPod_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPod.SelectedRows.Count != 0)
                {
                    Podcast podcast = (Podcast)dgvPod.SelectedRows[0].Tag;
                    HamtaAvsnitt(podcast.AvsnittLista);
                }
            }
            catch (NullReferenceException)
            { return; }
        }

        private void HamtaAvsnitt(List<Avsnitt> avsnittLista)
        {
            lbAvsnitt.Items.Clear();

            if (avsnittLista != null)
            {
                foreach (Avsnitt avsnitt in avsnittLista)
                {
                    lbAvsnitt.Items.Add(avsnitt);
                }
            }
        }

        private int konverteraUppdateringsTextTillVarde(string valdText)
        {
            int uppdateringsfrekvens = 0;
            switch (valdText)
            {
                case "":
                    uppdateringsfrekvens = 0;
                    break;
                case "1 min":
                    uppdateringsfrekvens = 60000;
                    break;
                case "3 min":
                    uppdateringsfrekvens = 180000;
                    break;
                case "5 min":
                    uppdateringsfrekvens = 300000;
                    break;
                case "10 min":
                    uppdateringsfrekvens = 600000;
                    break;
            }
            return uppdateringsfrekvens;
        }

        private string konverteraUppdateringsVardeTillText(int vardeInt)
        {
            string uppdateringsfrekvens = "0";
            switch (vardeInt)
            {
                case 60000:
                    uppdateringsfrekvens = "1 min";
                    break;
                case 180000:
                    uppdateringsfrekvens = "3 min";
                    break;
                case 300000:
                    uppdateringsfrekvens = "5 min";
                    break;
                case 600000:
                    uppdateringsfrekvens = "10 min";
                    break;
            }
            return uppdateringsfrekvens;
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

        private void dgvPod_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            harAndrats = true;
        }

        private void dgvPod_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPod.Rows.Count < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            var rad = dgvPod.Rows[e.RowIndex];
            if (rad.Tag == null)
            {
                return;
            }

            var podcast = (Podcast)rad.Tag;
            podcast.Titel = (String)rad.Cells["clmNamn"].Value;
            var kat = rad.Cells["clmKategori"].Value;
            if (kat is String)
            {
                podcast.PodcastKategori = KategoriHanterare.getKategori((String)kat);
            }

            //else if (kat is Kategori)
            //{
            //    podcast.PodcastKategori = (Kategori)kat;
            //}
            string uppdateringsfrek = (String)rad.Cells["clmUppdateringsfrekvens"].Value.ToString();
            int uppdateringsIntervallet = konverteraUppdateringsTextTillVarde(uppdateringsfrek);
            try
            {
                podcast.setUppdateringsFrekvensen(uppdateringsIntervallet);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "   " + ex.GetType());
            }
            harAndrats = false;
            uppdateraPodcast();


        }

        private void dgvPod_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnTaBortPod_Click(object sender, EventArgs e)
        {

            var podcast = dgvPod;
            if (podcast.SelectedRows.Count < 1)
            {
                MessageBox.Show("Du måste starta en podcast från podcast-rutan för att kunna ta bort den!");
                return;
            }
            if (podcast.SelectedRows[0] == null)
            {

                return;
            }
            int radIndex = podcast.SelectedRows[0].Index;

            Podcast valdPodcast = (Podcast)podcast.Rows[radIndex].Tag;
            podcastHanterare.taBortPodcast(valdPodcast);



            uppdateraPodcast();
            lbAvsnitt.Items.Clear();
        }

        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                int valdRadIndex = dgvPod.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPod.Rows[valdRadIndex];
                string podnamn = Convert.ToString(selectedRow.Cells["clmNamn"].Value);
                Podcast nyPodcast = new Podcast();
                List<Podcast> podcastList = PodcastHanterare.HamtaPodcasts();


                int index = podcastList.FindIndex(a => a.Titel == podnamn);

                Uri nyURI = new Uri(tbUrl.Text.Trim());
                Kategori nyKategori = (Kategori)cmbKat.SelectedItem;
                string valdUppdatering = cmbUppdatering.SelectedItem.ToString();
                int nyUppdategingsfrekvens = konverteraUppdateringsTextTillVarde(valdUppdatering);
                var rh = podcastHanterare.getRssHamtare();
                var podcastNy = rh.HamtaPodcast(nyURI);
                podcastList[index] = podcastNy;
                podcastList[index].PodcastKategori = nyKategori;
                podcastList[index].UppdateringsFrekvens = nyUppdategingsfrekvens;

            }

            catch (Exception ex)
            {
                string felmeddelande = "";
                if (ex is ValideringsException)
                {
                    felmeddelande = ex.Message;
                }
                if (ex is TextFaltArTomException)
                {
                    felmeddelande = "URL fältet får inte vara tomt!";
                    tbUrl.Focus();
                }
                if (ex is UriFormatException)
                {
                    felmeddelande = "Vänligen ange en giltig URL!";
                    tbUrl.Text = "";
                    tbUrl.Focus();
                }
                if (ex is XmlException)
                {
                    felmeddelande = "XML Datan kunde inte läsas! Vänligen ange en giltig XML URL!";
                    tbUrl.Focus();
                }
                if (ex is ArgumentException)
                {
                    felmeddelande = "Du måste välja en kategori från komboboxen till den nya podcasten!";

                }
                else
                {
                    felmeddelande = ex.Message + "   " + ex.GetType();
                }

                MessageBox.Show(felmeddelande, "Fel uppstod!");
            }

            uppdateraPodcast();
        }

        private void btnVisaPodcastsPerKategori_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori valdKategori = (Kategori)cmbKat.SelectedItem;
                Validering.valideraKategoriAngivet(valdKategori);
                uppdateraPodcastPerKategori(valdKategori);
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Du måste välja en kategori från kategorilistan bredvid!");
            }

        }

        private void btnVisaAllaPodcasts_Click(object sender, EventArgs e)
        {
            uppdateraPodcast();
        }

        private void dgvPod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPod.Rows[e.RowIndex];

            Podcast valdPodcast = (Podcast)row.Tag;
        }
    }
}

