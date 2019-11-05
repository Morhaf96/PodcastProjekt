using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Models
{
    public class Avsnitt : Podcast
    {
        public string avsnittTitel { get; set; }
        public string Beskrivning { get; set; }

        public Avsnitt()
        {

        }


        public override string GetTitel()
        {
            return avsnittTitel;
        }


        public override string ToString()
        {
            return avsnittTitel;
        }

    }

}