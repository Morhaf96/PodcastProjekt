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

        public XmlLasare(string sokvag) {
            this.sokvag = sokvag;
        }

        public string las() {
            FileStream fs;

            try{
                fs = new FileStream(sokvag, FileMode.Open,FileAccess.Read);
            }

            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                throw ex;
            }

            StreamReader sr = new StreamReader(fs);
            var xmlString = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            
            return xmlString;
        }
    }
}
