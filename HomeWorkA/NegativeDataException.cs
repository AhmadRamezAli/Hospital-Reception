using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class NegativeDataException : NotValidDataException
    {
        public NegativeDataException():base("should be positive value,your input isn't valid")
        {
        }
    }
}
