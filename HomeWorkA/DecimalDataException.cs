using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class DecimalDataException : NotValidDataException
    {
        public DecimalDataException():base(" should be decimal,your input isn't valid")
        {
        }
    }
}
