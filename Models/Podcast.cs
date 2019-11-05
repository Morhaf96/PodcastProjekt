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
    public class Podcast
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

        public Podcast()
        {

        }


        public virtual string GetTitel()
        {
            return Titel;
        }


        private void UppdateraTimer()
        {
            timer.Interval = UppdateringsFrekvens;
        }

        public void SetUppdateringsFrekvensen(int intervall)
        {
            UppdateringsFrekvens = intervall;
            UppdateraTimer();
        }


        public void StartaTimer()
        {
            timer.Interval = UppdateringsFrekvens;
            timer.Tick += OnTimerTick;
            timer.Enabled = true;
        }


        public void OnTimerTick(object sender, EventArgs e)
        {
            if (TimerTick != null)
                TimerTick(this, EventArgs.Empty);

        }
    }
}
