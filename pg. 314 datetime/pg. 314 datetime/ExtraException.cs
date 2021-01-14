using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._314_datetime
{
    class ExtraException : Exception
    {
        public ExtraException()
            : base() { }
        public ExtraException(string message)
            : base(message) { }
    }
}
