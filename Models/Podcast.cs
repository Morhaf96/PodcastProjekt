using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace PodcastProjekt.Models
{
    public class Podcast : IXmlSerializable
    {
        public List<Avsnitt> AvsnittLista { get; set; }
        public Uri Uri { get; set; }
        public Kategori PodcastKategori { get; set; }
        public string Titel { get; set; }
        public string KategoriNamn;
        private Timer timer = new Timer();
        public int UppdateringsFrekvens = 0;


        public delegate void OnTimerTickEventHandler(object sender, EventArgs e);
        public event OnTimerTickEventHandler TimerTick;

        public Podcast() {
        
        }

        public Podcast(Uri uri) {
            Uri = uri;
            AvsnittLista = new List<Avsnitt>();

        }

        public Uri getPodcastUri() { 
            return Uri;
        }

        public Kategori getPodcastKategori() {
            return PodcastKategori;
        }

        public int getUppdateringsFrekvens()
        {
            return UppdateringsFrekvens;
        }

        public void initialiseraKategori() {
            PodcastKategori = KategoriHanterare.getKategori(KategoriNamn);
        }

        private void uppdateraTimer() {
            timer.Interval = UppdateringsFrekvens;
        }

        public void setUppdateringsFrekvensen(int intervall){
            UppdateringsFrekvens = intervall;
            uppdateraTimer();
        }

        public int getUppdateringsFrekvensen() {
            return UppdateringsFrekvens;
        }

        public void startaTimer() {
            timer.Interval = UppdateringsFrekvens;
            timer.Tick += onTimerTick;
            timer.Enabled = true;
        }

        public XmlSchema GetSchema() {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader xmlLasare) {
            Uri = new Uri(xmlLasare.GetAttribute("Uri"));
            Titel = xmlLasare.GetAttribute("Titel");
            KategoriNamn = xmlLasare.GetAttribute("PodcastKategori");
            try {
                string uppdateringsfrekvens = xmlLasare.GetAttribute("UppdateringsFrekvens");
                UppdateringsFrekvens = int.Parse(uppdateringsfrekvens);
            }
            catch (Exception ex){
                Console.WriteLine("XML kunde inte läsa/int.Parse:a uppdateringsfrekvensen");
            }
            xmlLasare.Skip();
        }

        public void WriteXml(XmlWriter writer) {
            writer.WriteAttributeString("Uri", Uri.AbsoluteUri);
            writer.WriteAttributeString("Titel", Titel);
            writer.WriteAttributeString("PodcastKategori", PodcastKategori.KategoriNamn);
            writer.WriteAttributeString("UppdateringsFrekvens", UppdateringsFrekvens.ToString());
        }

        public void onTimerTick(object sender, EventArgs e)
        {
            if (TimerTick != null)
                TimerTick(this, EventArgs.Empty);

        }
    }
}
