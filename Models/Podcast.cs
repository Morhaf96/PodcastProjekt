using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Models
{
    public class Podcast
    {
        public List<Avsnitt> AvsnittLista { get; set; }
        public Uri Uri { get; set; }
        public Kategori PodcastKategori { get; set; }
        public string Titel { get; set; }

        public long UppdateringsFrekvens = 0;
    }
}
