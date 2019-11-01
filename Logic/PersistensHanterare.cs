using PodcastProjekt.Data;
using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastProjekt.Logic
{
    class UthallighetsHanterare
    {
        private string filnamn = "PodcastSparadData.xml";
        public string Url;

        public UthallighetsHanterare()
        {
            string befentligSokvag = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            Url = Path.Combine(befentligSokvag, filnamn);
        }

        public PersistentFil Las()
        {
            string xmlString = "";
            XmlLasare lasare = new XmlLasare(Url);
            try
            {
                 xmlString = lasare.las();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Kunde inte läsa in sparade Podcasts. Sparfilen saknas!"); 
            }



            PersistentFil data = new PersistentFil().Deserialize(xmlString);

            for (int i = 0; i < data.podcastLista.Count; i++)
            {
                Podcast podcasts = data.podcastLista[i];
                PodcastHanterare.uppdateraPodcastAvsnitt(podcasts);

            }

            return data;
        }

        public void Skriv(PersistentFil persistentFil)
        {

            string xml = persistentFil.Serialize();
            XmlSkrivare skrivare = new XmlSkrivare(xml, Url);
             skrivare.SkrivXml();
        }


    }
}
