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

        Kategori kategori = new Kategori();
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

        }
    }
}
