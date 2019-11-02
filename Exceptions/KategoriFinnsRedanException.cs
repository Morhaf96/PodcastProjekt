using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Exceptions
{
    class KategoriFinnsRedanException : Exception
    {
        public KategoriFinnsRedanException() : base() { }
        public KategoriFinnsRedanException(string message) : base(message) { }
    }
}
