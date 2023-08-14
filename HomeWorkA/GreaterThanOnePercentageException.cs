using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class GreaterThanOnePercentageException : NotValidDataException
    {
        public GreaterThanOnePercentageException():base("should be between 0 to 1,your input isn't valid")
        {
        }
    }
}
