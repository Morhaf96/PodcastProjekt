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
    class JsonLasare
    {
        private readonly JsonSerializer jsonSerializer;
        private readonly string filnamn;

        public JsonLasare(string filnamn)
        {
            this.filnamn = filnamn;
            jsonSerializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.All };
        }
        public List<Kategori> lasKategoriLista()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filnamn))
                {
                    using (JsonTextReader jtr = new JsonTextReader(sr))
                    {
                        return jsonSerializer.Deserialize<List<Kategori>>(jtr);
                    }
                }
            }
            catch
            {
                return new List<Kategori>();
            }
        }

        public List<Podcast> lasPodcastLista()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filnamn))
                {
                    using (JsonTextReader jtr = new JsonTextReader(sr))
                    {
                        return jsonSerializer.Deserialize<List<Podcast>>(jtr);
                    }
                }
            }
            catch
            {
                return new List<Podcast>();
            }
        }
    }
}
