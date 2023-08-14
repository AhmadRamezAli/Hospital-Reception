using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class EmptyFieldException : NotValidDataException
    {
        public EmptyFieldException():base("shouldn't be empty,your input isn't valid")
        {
        }
    }
}
