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

        public Avsnitt(string titel)
        {
            this.Titel = titel;
        }

        public Avsnitt(string titel, string beskrivning)
        {
            this.Titel = titel;
            this.Beskrivning = beskrivning;
        }

        public override string ToString()
        {
            return Titel;
        }

    }
    
}
