using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PodcastProjekt.Models
{
    class UthallighetsFil
    {
        public List<Podcast> podcastLista;
        public List<Kategori> kategoriLista;
        
        public UthallighetsFil(List<Podcast> podcastLista, List<Kategori> kategoriLista)
        {
            this.podcastLista = podcastLista;
            this.kategoriLista = kategoriLista;
        }

        public UthallighetsFil()
        {
            podcastLista = new List<Podcast>();
            kategoriLista = new List<Kategori>();
        }

        public string Serialize()
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(UthallighetsFil));

            using (var stringWriter = new StringWriter()){

                using (XmlWriter XMLWriter = XmlWriter.Create(stringWriter))
                {
                    xsSubmit.Serialize(stringWriter, this);
                    return stringWriter.ToString();
                }

            }
        }

        public UthallighetsFil Deserialize(string serializedString)
        {

            XmlSerializer xsSubmit = new XmlSerializer(typeof(UthallighetsFil));


            using (var stringReader = new StringReader(serializedString))
            {
                try
                {
                    return xsSubmit.Deserialize(stringReader) as UthallighetsFil;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex);
                    return new UthallighetsFil();
                }

            }
        }
    }
}
