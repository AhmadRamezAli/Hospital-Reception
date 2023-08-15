using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class NotValidNameException : NotValidDataException
    {
        public NotValidNameException():base("should be from 'a-z' or'A-Z' ,your input isn't valid!!!!")
        {
        }
    }
}
