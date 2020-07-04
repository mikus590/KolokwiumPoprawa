using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Exceptions
{
    public class NoSuchFireFighterException : Exception
    {
        public NoSuchFireFighterException(String warning) : base(warning)
        {


        }
    }
}
