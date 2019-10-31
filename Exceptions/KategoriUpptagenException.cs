using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Exceptions
{
    class KategoriUpptagenException : Exception 
    {
        public KategoriUpptagenException() : base() { }
        public KategoriUpptagenException(string message) : base(message) { }
    }
}
