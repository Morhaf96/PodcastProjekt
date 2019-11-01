using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Exceptions
{
    class KategoriNullException : Exception
    {

        public KategoriNullException() : base() { }
        public KategoriNullException(string message) : base(message) { }
    }
}
