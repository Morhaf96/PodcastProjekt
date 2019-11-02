using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Data
{
    class XmlSkrivare
    {
        public string sokvag;
        public string xml;

        public XmlSkrivare(string sokvag, string xml)
        {
            this.sokvag = sokvag;
            this.xml = xml;
        }


        public void SkrivXml() { 
            var fs = new FileStream(sokvag, FileMode.Create, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.Write(xml);
            sw.Close();
            fs.Close();
        }
    }
}
