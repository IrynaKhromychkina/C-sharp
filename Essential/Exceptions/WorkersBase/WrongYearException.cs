using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBase
{
    class WrongYearException : Exception
    {
        public WrongYearException(string message) : base(message) { }
    }
}
