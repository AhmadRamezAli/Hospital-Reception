using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class NotValidDataException : Exception
    {
        public NotValidDataException(string message) : base(message)
        {

        }
        public NotValidDataException():base(" your input isn't valid")
        {
           
        }
        
        
    }
}
