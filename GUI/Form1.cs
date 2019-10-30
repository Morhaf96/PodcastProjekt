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

namespace PodcastProjekt
{
    public partial class Form1 : Form
    {
        private PodcastHanterare podcastHanterare = new PodcastHanterare();

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
            string textAttLagga = tbKategori.Text.Trim();
            if (!textAttLagga.Equals(""))
            {
                kategori.laggTillKategori(textAttLagga);
                tbKategori.Text = "";
                cmbKat.Items.Clear();
                lvKat.Items.Clear();

                try
                {

                    foreach (var kat in kategori.getKategoriLista())
                    {
                        cmbKat.Items.Add(kat);
                        lvKat.Items.Add(kat);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                uppdateraKategori();
                
            }

            else {
                MessageBox.Show("Du måste ange ett giltigt namn på kategorin!", "Felmeddelande");
            }

            
        }

        private void btnSparaKat_Click(object sender, EventArgs e)
        {
            if (!tbKategori.Text.Equals(""))
            {
                string gammaltNamn = lvKat.SelectedItems.ToString();
                string nyttNamn = tbKategori.Text.ToString();
                tbKategori.Text = "";
                kategori.bytNamn(gammaltNamn, nyttNamn);
                uppdateraKategori();


            }

            else {
                MessageBox.Show("Du måste välja en kategori för att ändra namnet på den!");
            }
        }

        private void btnTaBortKat_Click(object sender, EventArgs e)
        {
            string kategoriNamn = tbKategori.Text.Trim();
            kategori.taBortKategori(kategoriNamn);
            uppdateraKategori();
            tbKategori.Text = "";

        }

        private void uppdateraKategori() {
            cmbKat.Items.Clear();
            lvKat.Items.Clear();
            try
            {
                foreach (var c in kategori.getKategoriLista())
                {
                    
                    lvKat.Items.Add(c);
                    cmbKat.Items.Add(c);
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
            foreach (var podcast in podcastHanterare.HamtaPodcasts())
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

        private void btnLaggTillPod_Click(object sender, EventArgs e)
        {
            string hamtadUrl = tbUrl.Text.Trim();
            Uri hamtadUri = new Uri(hamtadUrl);
            podcastHanterare.LaggTillStream(hamtadUri);
            uppdateraPodcast();
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
            
            tbBeskrivning.Clear();
            if (lbAvsnitt.SelectedItems.Count == 0)
            {
                return;
            }
            if (lbAvsnitt.SelectedItems[0] != null)
            {
                var podcast = (Avsnitt)lbAvsnitt.SelectedItems[0];
                Avsnitt avsnitt = new Avsnitt();
                string titel = avsnitt.Titel;
                string beskrivning = avsnitt.Beskrivning;
                tbBeskrivning.Text = titel + "\n \n" + beskrivning;
            }


        }
        }
    }

