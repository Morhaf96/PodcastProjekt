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
        Kategori enKategoriLista = new Kategori();
        public Form1()
        {
            InitializeComponent();
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
            string textAttLagga = txbKategori.Text.Trim();
            if (!textAttLagga.Equals(""))
            {
                enKategoriLista.laggTillKategori(textAttLagga);
                txbKategori.Text = "";
                
            }

            else {
                MessageBox.Show("Du måste ange ett giltigt namn på kategorin!", "Felmeddelande");
            }

        }
    }
}
