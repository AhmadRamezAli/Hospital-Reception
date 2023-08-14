using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class DoubleDataException : NotValidDataException
    {
        public DoubleDataException():base("should be double ,your input isn't valid")
        {
        }
    }
}
