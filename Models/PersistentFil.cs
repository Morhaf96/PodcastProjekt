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
    class PersistentFil
    {
        public List<Podcast> podcastLista;
        public List<Kategori> kategoriLista;
        
        public PersistentFil(List<Podcast> podcastLista, List<Kategori> kategoriLista){
            this.podcastLista = podcastLista;
            this.kategoriLista = kategoriLista;
        }

        public PersistentFil() {
            podcastLista = new List<Podcast>();
            kategoriLista = new List<Kategori>();
        }

        public string Serialize(){
            XmlSerializer xsSubmit = new XmlSerializer(typeof(PersistentFil));

            using (var stringWriter = new StringWriter()){

                using (XmlWriter XMLWriter = XmlWriter.Create(stringWriter))
                {
                    xsSubmit.Serialize(stringWriter, this);
                    return stringWriter.ToString();
                }

            }
        }

        public PersistentFil Deserialize(string serializedString) {

            XmlSerializer xmlSerializeer = new XmlSerializer(typeof(PersistentFil));

            using (var stringReader = new StringReader(serializedString)){
                try{
                    return xmlSerializeer.Deserialize(stringReader) as PersistentFil;
                }
                catch (InvalidOperationException ex){
                    Console.WriteLine(ex);
                    return new PersistentFil();
                }

            }
        }
    }
}
