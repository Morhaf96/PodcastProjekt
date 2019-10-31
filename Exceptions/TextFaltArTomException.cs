using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Exceptions
{
    class TextFaltArTomException : Exception
    {
        public TextFaltArTomException() : base() { }
        public TextFaltArTomException(string message) : base(message) { }
    }
}
