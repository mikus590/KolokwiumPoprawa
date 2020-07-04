using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Exceptions
{
    public class NoSuchActionEx : Exception
    {
        public NoSuchActionEx() 
        {

        }
        public NoSuchActionEx(String warning) : base(warning)
        {


        }
    }

    
}
