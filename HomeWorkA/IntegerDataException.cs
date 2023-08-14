using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class IntegerDataException : NotValidDataException
    {
        public IntegerDataException():base("should be integer, your input isn't valid")
        {
           
        }

    }
}
