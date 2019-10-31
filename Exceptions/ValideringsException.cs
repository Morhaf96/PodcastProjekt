using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Exceptions
{
    public class ValideringsException : Exception
    {
        public ValideringsException() : base() { }
        public ValideringsException(string message) : base(message) { }

    }
}
