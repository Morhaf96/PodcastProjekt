using PodcastProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Models
{
    public class Kategori
    {
        public string KategoriNamn { get; set; }

        public Kategori()
        {

        }

        public Kategori(string kategoriNamn)
        {
            KategoriNamn = kategoriNamn;
        }

        public override string ToString()
        {
            return KategoriNamn;
        }
    }
}
