using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Models
{
    public class Avsnitt : Podcast
    {
        public string Titel { get; set; }
        public string Beskrivning { get; set; }

        public Avsnitt()
        {

        }

        public Avsnitt(string titel)
        {
            this.Titel = titel;
        }

        public override string getTitel()
        {
            return Titel;
        }

        public Avsnitt(string titel, string beskrivning)
        {
            this.Titel = titel;
            this.Beskrivning = beskrivning;
        }

        public string getBeskrivning(Avsnitt avsnitt)
        {
            return Beskrivning;
        }

        public override string ToString()
        {
            return Titel;
        }

    }

}