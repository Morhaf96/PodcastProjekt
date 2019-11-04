using Newtonsoft.Json;
using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Data
{
    class JsonSkrivare
    {
        private readonly JsonSerializer jsonSerializer;
        private readonly string filnamn;

        public JsonSkrivare(string filnamn)
        {
            jsonSerializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.All };
            this.filnamn = filnamn;
        }
        public void sparaKategorier(List<Kategori> kategoriLista)
        {
            using (StreamWriter sw = new StreamWriter(filnamn))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jsonSerializer.Serialize(jtw, kategoriLista);
                }
            }
        }
        public void sparaPodcasts(List<Podcast> podcastLista)
        {
            using (StreamWriter sw = new StreamWriter(filnamn))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jsonSerializer.Serialize(jtw, podcastLista);
                }
            }
        }
    }
}
