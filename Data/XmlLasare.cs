using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PodcastProjekt.Data
{
    class XmlLasare
    {
        public string sokvag;

        public XmlLasare(string enSokvag)
        {
           sokvag = enSokvag;
        }

        public string las()
        {

            FileStream fs;
            try
            {
                fs = new FileStream(sokvag, FileMode.Open, FileAccess.Read);
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message + " Från XmlLäsare.Las()");
                throw ex;
            }

            StreamReader sr = new StreamReader(fs);
            string xmlString = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            return xmlString;
        }
    }
}
